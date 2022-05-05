using ServiceStack.Script;
using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;
using VetClinicMS.Models;
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class Calendar : Form
    {
        readonly WindowState windowState = new WindowState();
        public Calendar()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;
            this.onLoad(null);
        }

        private void onLoad(string date)
        {
            eventsPanel.Controls.Clear();

            using (ModelContext database = new ModelContext())
            {
                var doctors = database.Users.Where(u => u.role == 2).ToList();
                var pets = database.PetList.ToList();

                var events = database.Events.OrderBy(e => e.from).ToList();

                if (Global.Usermode == 2) {
                    events = events.Where(e => e.doctorId == Global.UserId).ToList();
                }

                if (date != null)
                {
                    var today = DateTime.ParseExact(date, "dd.MM.yyyy", null);
                    var tomorrow = DateTime.ParseExact(date, "dd.MM.yyyy", null).AddDays(1);
                    events = events.ToList().Where(e => e.from >= today && e.from <= tomorrow).ToList();
                } else
                {
                    var today = DateTime.Now.Date;
                    var tomorrow = today.AddDays(1).Date;

                    events = events.ToList().Where(e => e.from >= today && e.from <= tomorrow).ToList();
                }

                doctorCombo.DataSource = doctors;
                doctorCombo.ValueMember = "id";
                doctorCombo.DisplayMember = "username";

                petsCombo.DataSource = pets;
                petsCombo.ValueMember = "petId";
                petsCombo.DisplayMember = "name";

                events.ForEach(single => {
                    EventControl eventControl = new EventControl();
                    eventControl.Id = single.id;
                    eventControl.Title = single.title;
                    eventControl.Description = single.description;
                    eventControl.FromDate = single.from;
                    eventControl.ToDate = single.to;
                    eventControl.Phone = single.phone;
                    eventControl.Email = single.email;
                    eventControl.PetId = single.petId;
                    eventControl.DoctorId = single.doctorId;
                    eventControl.Click += new System.EventHandler(this.EventControl_Click);
                    eventControl.setValues();
                    eventsPanel.Controls.Add(eventControl);
                });
            }
        }

        private void EventControl_Click(object sender, EventArgs e)
        {
            EventControl singleEvent = (EventControl)sender;

            singleEventId.Text = singleEvent.Id.ToString();
            eventName.Text = singleEvent.Title;
            eventDescription.Text = singleEvent.Description;
            phoneValue.Text = singleEvent.Phone;
            emailValue.Text = singleEvent.Email;
            doctorCombo.SelectedValue = singleEvent.DoctorId;
            petsCombo.SelectedValue = singleEvent.PetId;
            fromValue.Text = singleEvent.FromDate.ToString();
            toValue.Text = singleEvent.ToDate.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.openPets(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            windowState.openDashboard(this);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            windowState.openMedicines(this);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            windowState.openWiki(this);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            windowState.openAdministration(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CancelModification_Click(object sender, EventArgs e)
        {
            singleEventId.Text = "";
            eventName.Text = "";
            eventDescription.Text = "";
            phoneValue.Text = "";
            emailValue.Text = "";
            doctorCombo.SelectedValue = 0;
            petsCombo.SelectedValue = 0;
            fromValue.Text = "";
            toValue.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (singleEventId.Text == "")
            {
                using (var database = new ModelContext())
                {
                    var newEvent = new EventModel()
                    {
                        title = eventName.Text,
                        description = eventDescription.Text,
                        email = emailValue.Text,
                        phone = phoneValue.Text,
                        petId = Int32.Parse(petsCombo.SelectedValue.ToString()),
                        doctorId = Int32.Parse(doctorCombo.SelectedValue.ToString()),
                        from = DateTime.Parse(fromValue.Text),
                        to = DateTime.Parse(toValue.Text)
                    };

                    database.Events.Add(newEvent);
                    database.SaveChanges();
                }
            }
            else
            {
                using (var database = new ModelContext())
                {
                    int id = Int32.Parse(singleEventId.Text);
                    var singleEvent = database.Events.Where(p => p.id == id).First();

                    singleEvent.title = eventName.Text;
                    singleEvent.description = eventDescription.Text;
                    singleEvent.email = emailValue.Text;
                    singleEvent.phone = phoneValue.Text;
                    singleEvent.doctorId = Int32.Parse(doctorCombo.SelectedValue.ToString());
                    singleEvent.petId = Int32.Parse(petsCombo.SelectedValue.ToString());
                    singleEvent.from = DateTime.Parse(fromValue.Text);
                    singleEvent.to = DateTime.Parse(toValue.Text);

                    database.SaveChanges();
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.onLoad(dateTime.Value.ToString("dd.MM.yyyy"));
        }
    }
}
