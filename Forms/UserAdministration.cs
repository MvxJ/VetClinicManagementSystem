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
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class UserAdministration : Form
    {
        readonly WindowState windowState = new WindowState();
        public UserAdministration()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;

            if (Global.Usermode != 1)
            {
                this.guna2Button5.Hide();
                this.pictureBox5.Hide();
            }

            this.LoadUserControls();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            windowState.OpenWiki(this);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            windowState.OpenMedicines(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.OpenPets(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.OpenCalendar(this);
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            windowState.OpenDashBoard(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            windowState.Minimalize(this);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (userId.Text == "")
            {
                using (var database = new ModelContext())
                {
                    int roleInt = 0;
                    string role = roleBox.Text;
                    switch (role)
                    {
                        case "Local Admins":
                            roleInt = 1;
                            break;
                        case "Doctor":
                            roleInt = 2;
                            break;
                        case "Recepcionist":
                            roleInt = 0;
                            break;
                    }

                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(password.Text);

                    var user = new UserModel()
                    {
                        username = userName.Text,
                        name = name.Text,
                        surname = surname.Text,
                        role = roleInt,
                        email = email.Text,
                        password = passwordHash
                    };

                    database.Users.Add(user);
                    database.SaveChanges();
                }
            }
            else
            {
                using (var database = new ModelContext())
                {
                    int id = Int32.Parse(userId.Text);
                    var user = database.Users.Where(p => p.id == id).First();
                    int roleInt = 0;
                    string role = roleBox.Text;
                    switch (role)
                    {
                        case "Local Admins":
                            roleInt = 1;
                            break;
                        case "Doctor":
                            roleInt = 2;
                            break;
                        case "Recepcionist":
                            roleInt = 0;
                            break;
                    }

                    

                    user.username = userName.Text;
                    user.name = name.Text;
                    user.surname = surname.Text;
                    user.role = roleInt;
                    user.email = email.Text;

                    if (password.Text != "")
                    {
                        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password.Text);
                        user.password = passwordHash;
                    }

                    database.SaveChanges();
                }
            }
        }

        private void CancelModification_Click(object sender, EventArgs e)
        {
            userId.Text = "";
            userName.Text = "";
            surname.Text = "";
            name.Text = "";
            roleBox.Text = "";
            password.Text = "";
            email.Text = "";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            windowState.LogOut(this);
        }

        private void LoadUserControls()
        {
            using (ModelContext database = new ModelContext())
            {
                panel1.Controls.Clear();
                var userList = database.Users.ToList();

                userList.ForEach(user => {
                    AdministrationUserControl userControl = new AdministrationUserControl();
                    userControl.Password = user.password;
                    userControl.Surname = user.surname;
                    userControl.Names = user.name;
                    userControl.UserName = user.username;
                    userControl.Email = user.email;
                    userControl.Id = user.id;
                    userControl.Role = user.role;
                    userControl.setValues();
                    userControl.Click += new System.EventHandler(this.UserControl_Click);
                    panel1.Controls.Add(userControl);
                });
            }
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            AdministrationUserControl user = (AdministrationUserControl)sender;
            string roles = "";
            switch (user.Role)
            {
                case 1:
                    roles = "Local Admins";
                    break;
                case 2:
                    roles = "Doctor";
                    break;
                case 0:
                    roles = "Recepcionist";
                    break;
            }

            
            name.Text = user.Names;
            surname.Text = user.Surname;
            userName.Text = user.UserName;
            email.Text = user.Email;
            userId.Text = user.Id.ToString();
            roleBox.Text = roles;
            password.Text = "";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadUserControls();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.SearchUserAdminControl();
        }

        private void SearchUserAdminControl()
        {
            using (ModelContext database = new ModelContext())
            {
                string search = guna2TextBox1.Text;
                panel1.Controls.Clear();
                var usersList = database.Users.Where(a => a.name == search || a.surname == search || a.email == search || a.username == search);

                usersList.ToList().ForEach(user => {
                    AdministrationUserControl userControl = new AdministrationUserControl();
                    userControl.Password = user.password;
                    userControl.Surname = user.surname;
                    userControl.Names = user.name;
                    userControl.UserName = user.username;
                    userControl.Email = user.email;
                    userControl.Id = user.id;
                    userControl.Role = user.role;
                    userControl.setValues();
                    userControl.Click += new System.EventHandler(this.UserControl_Click);
                    panel1.Controls.Add(userControl);
                });
            }
        }
    }
}
