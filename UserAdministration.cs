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
    public partial class UserAdministration : Form
    {
        readonly WindowState windowState = new WindowState();
        public UserAdministration()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            windowState.openWiki(this);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            windowState.openMedicines(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.openPets(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.openCalendar(this);
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            windowState.openDashboard(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
