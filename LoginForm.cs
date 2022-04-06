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
    public partial class LoginForm : Form
    {
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
    }
}
