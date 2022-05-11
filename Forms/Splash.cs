using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Models;
using VetClinicMS.Services;

namespace VetClinicMS
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        int startpoint = 0;

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            LoadingProgressBar.Value = startpoint;
            LoadingValueLabel.Text = startpoint.ToString() + "%";

            if (LoadingProgressBar.Value == 75)
            {
                var dataService = new DataService();
                dataService.seedData();
            }

            if (LoadingProgressBar.Value == 100)
            {
                LoadingValueLabel.Text = "";
                LoadingProgressBar.Value = 0;
                SplashTimer.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
