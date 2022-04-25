using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VetClinicMS.Models;

namespace VetClinicMS
{
    public partial class LoginForm : Form
    {
        readonly WindowState windowState = new WindowState();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseLoginFormLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetLoginFormData_Click(object sender, EventArgs e)
        {
            PasswordTextbox.Text = "";
            UsernameTextbox.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "" || UsernameTextbox.Text == "") {
                MessageBox.Show("Informations missing!");
            } else {
                try {
                    using (var database = new ModelContext())
                    {
                        var user = database.Users.Where(u => u.username == UsernameTextbox.Text).First();
                        if (user != null)
                        {
                            if (BCrypt.Net.BCrypt.Verify(PasswordTextbox.Text, user.password))
                            {
                                Global.Username = user.name;
                                Global.Surname = user.surname;
                                Global.Usermode = user.role;
                                windowState.openDashboard(this);
                            } else
                            {
                                MessageBox.Show("Wrong login data!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Wrong login data!");
                        }
                    }
                    
                } catch (Exception exception) {
                    MessageBox.Show("Error: " + exception.Message);
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
