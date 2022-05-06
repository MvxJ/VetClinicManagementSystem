using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Models;

namespace VetClinicMS
{
    public partial class Pets : Form
    {
        UserService userService = new UserService();
        WindowState windowState = new WindowState();
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

        private void PetsControl_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error occured", "Error");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadUserControls();
        }

        private void LoadUserControls()
        {
            using (ModelContext database = new ModelContext())
            {
                panel1.Controls.Clear();
                var petsList = database.PetList.ToList();

                petsList.ForEach(pet => {
                    PetsControl petControl = new PetsControl();
                    petControl.note = pet.note;
                    petControl.pet = pet.pet;
                    petControl.age = pet.age;
                    petControl.name = pet.name;
                    petControl.owner = pet.onwer;
                    petControl.id = pet.petId;
                    petControl.image = pet.image;
                    petControl.setValues();
                    petControl.Click += new System.EventHandler(this.PetsControl_Click);
                    panel1.Controls.Add(petControl);
                });
            }
        }

        private void SearchUserControl()
        {
            using (ModelContext database = new ModelContext())
            {
                string search = guna2TextBox1.Text;
                panel1.Controls.Clear();
                var petsList = database.PetList.Where(a => a.name == search || a.onwer == search || a.pet == search);

                petsList.ToList().ForEach(pet => {
                    PetsControl petControl = new PetsControl();
                    petControl.note = pet.note;
                    petControl.pet = pet.pet;
                    petControl.age = pet.age;
                    petControl.name = pet.name;
                    petControl.owner = pet.onwer;
                    petControl.id = pet.petId;
                    petControl.image = pet.image;
                    petControl.setValues();
                    petControl.Click += new System.EventHandler(this.PetsControl_Click);
                    panel1.Controls.Add(petControl);
                });
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.SearchUserControl();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (petId.Text == "")
            {
                using (var database = new ModelContext())
                {
                    var pets = database.PetList.ToList();
                    int id = pets.Count + 1;
                    int age = Int32.Parse(guna2TextBox5.Text);
                    var pet = new PetsModel()
                    {
                        onwer = guna2TextBox6.Text,
                        age = age,
                        note = guna2TextBox2.Text,
                        name = guna2TextBox3.Text,
                        pet = guna2TextBox4.Text,
                        image = pictureBox8.ImageLocation
                    };

                    database.PetList.Add(pet);
                    database.SaveChanges();
                }
            }
            else
            {
                using (var database = new ModelContext())
                {
                    int id = Int32.Parse(petId.Text);
                    var pet = database.PetList.Where(p => p.petId == id).First();

                    pet.onwer = guna2TextBox6.Text;
                    pet.age = Int32.Parse(guna2TextBox5.Text);
                    pet.note = guna2TextBox2.Text;
                    pet.name = guna2TextBox3.Text;
                    pet.pet = guna2TextBox4.Text;
                    pet.image = pictureBox8.ImageLocation;

                    database.SaveChanges();
                }
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
        }
    }
}
