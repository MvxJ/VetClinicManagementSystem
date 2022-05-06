using ServiceStack.Script;
using System;
using System.Collections.Specialized;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;
using VetClinicMS.Models;
using VetClinicMS.Services;
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class Calendar : Form
    {
        readonly EventsService eventsService = new EventsService();
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
                    eventControl.SetValues();
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
            windowState.OpenPets(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            windowState.OpenDashBoard(this);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            windowState.OpenMedicines(this);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            windowState.OpenWiki(this);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            windowState.OpenUserAdministration(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            windowState.Minimalize(this);
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
            NameValueCollection list = new NameValueCollection();
            list["id"] = singleEventId.Text;
            list["title"] = eventName.Text;
            list["description"] = eventDescription.Text;
            list["email"] = emailValue.Text;
            list["phone"] = phoneValue.Text;
            list["petId"] = petsCombo.SelectedValue.ToString();
            list["doctorId"] = doctorCombo.SelectedValue.ToString();
            list["from"] = fromValue.Text;
            list["to"] = toValue.Text;

            if (singleEventId.Text == "")
            {
                eventsService.create(list);
            }
            else
            {
                eventsService.update(list);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.onLoad(dateTime.Value.ToString("dd.MM.yyyy"));
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            UserService user = new UserService();
            user.LogOut(this);
        }
    }
}
