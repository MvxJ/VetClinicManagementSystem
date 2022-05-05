using System;
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
            this.onLoad();
        }

        private void onLoad()
        {
            string date = calendarDate.ToString();

            using (ModelContext database = new ModelContext())
            {
                var doctors = database.Users.Where(u => u.role == 2).ToList();
                var pets = database.PetList.ToList();
                var events = database.Events.ToList();

                doctorCombo.DataSource = doctors;
                doctorCombo.ValueMember = "id";
                doctorCombo.DisplayMember = "username";

                petsCombo.DataSource = pets;
                petsCombo.ValueMember = "petId";
                petsCombo.DisplayMember = "name";

                events.ForEach(single => {
                    EventControl eventControl = new EventControl();
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
            doctorCombo.SelectedItem = singleEvent.DoctorId;
            petsCombo.SelectedItem = singleEvent.PetId;
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
            doctorCombo.SelectedItem = 0;
            petsCombo.SelectedItem = 0;
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
                        petId = petsCombo.SelectedIndex,
                        doctorId = doctorCombo.SelectedIndex,
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
                    singleEvent.doctorId = Int32.Parse(doctorCombo.Text);
                    singleEvent.petId = Int32.Parse(petsCombo.Text);
                    singleEvent.from = DateTime.Parse(fromValue.Text);
                    singleEvent.to = DateTime.Parse(toValue.Text);

                    database.SaveChanges();
                }
            }
        }
    }
}
