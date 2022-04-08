using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicMS
{
    public partial class Pets : Form
    {
        WindowState windowState = new WindowState();
        public Pets()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            windowState.openDashboard(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.openCalendar(this);
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
    }
}
