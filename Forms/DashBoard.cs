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

namespace VetClinicMS
{
    public partial class DashBoard : Form
    {
        readonly WindowState windowState = new WindowState();

        public DashBoard()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;
            
            if (Global.Usermode == 0)
            {
                this.guna2Button5.Hide();
                this.pictureBox5.Hide();
            }

            this.addSeriesToChart();
            this.countUsers();
            this.countArticles();
            this.countMeds();
            this.countVisits();
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
            windowState.openCalendar(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.openPets(this);
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.LogOut(this);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.addSeriesToChart();
            this.countUsers();
            this.countArticles();
            this.countMeds();
            this.countVisits();
        }
    }
}
