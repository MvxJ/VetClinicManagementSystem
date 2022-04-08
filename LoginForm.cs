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
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maksymilian.jachymcz\Documents\VetClinicDB.mdf;Integrated Security=True");
                    connection.Open();
                    string query = "SELECT name, surname, mode FROM UsersTable WHERE username='" + UsernameTextbox.Text + "' AND password ='" + PasswordTextbox.Text +"'";
                    SqlCommand command = new SqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Global.Username = reader.GetString(0);
                        Global.Surname = reader.GetString(1);
                        Global.Usermode = reader.GetInt32(2);
                        reader.Close();
                        windowState.openDashboard(this);
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Wrong login data!");
                        connection.Close();
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
