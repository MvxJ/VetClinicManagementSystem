using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VetClinicMS.Models;
using VetClinicMS.Services;
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class DashBoard : Form
    {
        readonly WindowState windowState = new WindowState();
        readonly UserService userService = new UserService();
        readonly EventsService eventsService = new EventsService();

        public DashBoard()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;
            
            if (!userService.checkUserAccess())
            {
                this.guna2Button5.Hide();
                this.pictureBox5.Hide();
            }

            this.addSeriesToChart();
            this.countUsers();
            this.countArticles();
            this.countMeds();
            this.countVisits();
            this.loadCalenadr();
        }

        private void loadCalenadr()
        {
            using (ModelContext database = new ModelContext())
            {
                var events = database.Events.OrderBy(e => e.from).ToList();

                if (Global.Usermode == 2)
                {
                    events = events.Where(e => e.doctorId == Global.UserId).ToList();
                }

                var today = DateTime.Now.Date;
                var tomorrow = today.AddDays(1).Date;

                events = eventsService.getEvents();

                calendarPanel.Controls.Clear();

                events.ForEach(single => {
                    DashBoardUserControl eventControl = new DashBoardUserControl();
                    eventControl.Title = single.title;
                    eventControl.Description = single.description;
                    eventControl.FromDate = single.from;
                    eventControl.ToDate = single.to;
                    eventControl.Phone = single.phone;
                    eventControl.Email = single.email;
                    eventControl.PetId = single.petId;
                    eventControl.DoctorId = single.doctorId;
                    eventControl.SetValues();
                    calendarPanel.Controls.Add(eventControl);
                });
            }
        }

        private void countUsers()
        {
            using (ModelContext database = new ModelContext())
            {
                var users = database.Users.ToList();
                usersAmount.Text = users.Count.ToString();
            }
        }

        private void countArticles()
        {
            using (ModelContext database = new ModelContext())
            {
                var articles = database.Articles.ToList();
                articlesAmount.Text = articles.Count.ToString();
            }
        }

        private void countMeds()
        {
            using (ModelContext database = new ModelContext())
            {
                var meds = database.Medicine.ToList();
                medsAmount.Text = meds.Count.ToString();
            }
        }

        private void countVisits()
        {
            using (ModelContext database = new ModelContext())
            {
                var visits = database.Events.ToList();
                visitsAmount.Text = visits.Count.ToString();
            }
        }

        private void addSeriesToChart()
        {
            using (ModelContext database = new ModelContext())
            {
                Dictionary<string, int> pets = new Dictionary<string, int>();
                var petsList = database.PetList.ToList();
                petsList.ForEach(pet => {
                    if (pets.ContainsKey(pet.pet))
                    {
                        pets[pet.pet]++;
                    } else
                    {
                        pets.Add(pet.pet, 1);
                    }
                });


                petsChart.Series["performace"].Points.Clear();

                foreach (KeyValuePair<string, int> row in pets)
                {
                    petsChart.Series["performace"].Points.AddXY(row.Key, row.Value);
                }

                Dictionary<string, int> events = new Dictionary<string, int>();
                var eventsList = database.Events.ToList();

                eventsList.ForEach(e => {
                    if (events.ContainsKey(e.from.ToString("dd.MM.yyyy"))) {
                        events[e.from.ToString("dd.MM.yyyy")]++;
                    } else {
                        events.Add(e.from.ToString("dd.MM.yyyy"), 1);
                    }
                });

                visitsChart.Series["visits"].Points.Clear();

                foreach (KeyValuePair<string, int> row in events)
                {
                    visitsChart.Series["visits"].Points.AddXY(row.Key, row.Value);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.OpenCalendar(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.OpenPets(this);
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

        private void Minimalize_Click(object sender, EventArgs e)
        {
            windowState.Minimalize(this);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            windowState.LogOut(this);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.addSeriesToChart();
            this.countUsers();
            this.countArticles();
            this.countMeds();
            this.countVisits();
            this.loadCalenadr();
        }
    }
}
