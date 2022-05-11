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
        readonly UserService userService = new UserService();

        public Calendar()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;

            if (!userService.checkUserAccess())
            {
                this.guna2Button5.Hide();
                this.pictureBox5.Hide();
            }

            this.onLoad(null);
        }

        private void onLoad(string date)
        {
            eventsPanel.Controls.Clear();
            eventsService.fetchEvents(this, date);
            eventsService.fetchDoctorsAndPets(this);
        }

        public void EventControl_Click(object sender, EventArgs e)
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
