﻿using System;
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
    }
}
