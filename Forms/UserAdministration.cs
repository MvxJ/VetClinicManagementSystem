using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        readonly UserService userService = new UserService();
        readonly WindowState windowState = new WindowState();
        public List<UserModel> users = null;

        public UserAdministration()
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
            try
            {
                NameValueCollection list = new NameValueCollection();

                list["id"] = userId.Text;
                list["userName"] = userName.Text;
                list["name"] = name.Text;
                list["surname"] = surname.Text;
                list["role"] = userService.GetRoleId(userId.Text).ToString();
                list["email"] = email.Text;
                list["password"] = "";


                if (userId.Text == "")
                {
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(password.Text);
                    list["password"] = passwordHash;

                    userService.create(list);
                }
                else
                {
                    if (password.Text != "")
                    {
                        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password.Text);
                        list["password"] = passwordHash;
                    }

                    userService.update(list);
                }
            }
            catch (Exception ex)
            {
                label9.Text = ex.Message;
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
            label9.Text = "";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            windowState.LogOut(this);
        }

        private void LoadUserControls()
        {
            userService.fetchUsers(this, null);
        }

        public void UserControl_Click(object sender, EventArgs e)
        {
            AdministrationUserControl user = (AdministrationUserControl)sender;
            name.Text = user.Names;
            surname.Text = user.Surname;
            userName.Text = user.UserName;
            email.Text = user.Email;
            userId.Text = user.Id.ToString();
            roleBox.Text = userService.SelectRole(user.Role);
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
            string search = guna2TextBox1.Text;
            userService.fetchUsers(this, search);
        }
    }
}
