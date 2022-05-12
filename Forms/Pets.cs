using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Models;
using VetClinicMS.Services;

namespace VetClinicMS
{
    public partial class Pets : Form
    {
        PetsService petsService = new PetsService();
        WindowState windowState = new WindowState();
        UserService userService = new UserService();

        public List<PetsModel> pets = null;

        public Pets()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;

            if (!userService.checkUserAccess())
            {
                this.guna2Button5.Hide();
                this.pictureBox5.Hide();
            }

            this.LoadUserControls();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            windowState.OpenDashBoard(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.OpenCalendar(this);
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

        public void PetsControl_Click(object sender, EventArgs e)
        {
            PetsControl pet = (PetsControl)sender;
            guna2TextBox3.Text = pet.name;
            guna2TextBox6.Text = pet.owner;
            guna2TextBox5.Text = pet.age.ToString();
            guna2TextBox4.Text = pet.pet;
            guna2TextBox2.Text = pet.note;
            petId.Text = pet.id.ToString();
            pictureBox8.ImageLocation = pet.image;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox8.ImageLocation = imageLocation;
                }
            }
            catch (Exception exception)
            {

                label8.Text = exception.Message;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadUserControls();
        }

        private void LoadUserControls()
        {
            petsService.fetchPets(this, null);
        }

        private void SearchUserControl()
        {
            string search = guna2TextBox1.Text;
            petsService.fetchPets(this, search);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.SearchUserControl();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                NameValueCollection list = new NameValueCollection();

                list["id"] = petId.Text;
                list["owner"] = guna2TextBox6.Text;
                list["age"] = guna2TextBox5.Text;
                list["pet"] = guna2TextBox4.Text;
                list["image"] = pictureBox8.ImageLocation;
                list["name"] = guna2TextBox3.Text;
                list["note"] = guna2TextBox2.Text;

                if (petId.Text == "")
                {
                    petsService.create(list);
                }
                else
                {
                    petsService.update(list);
                }
            } catch (Exception exception)
            {
                label8.Text = exception.Message;
            }
            
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            windowState.LogOut(this);
        }

        private void CancelModification_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Text = "";
            guna2TextBox6.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox2.Text = "";
            petId.Text = "";
            pictureBox8.ImageLocation = "";
            label8.Text = "";
        }
    }
}
