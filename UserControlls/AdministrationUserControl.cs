using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.UserControlls
{
    public partial class AdministrationUserControl : UserControl, IUserControl
    {
        readonly UserService userService = new UserService();

        public AdministrationUserControl()
        {
            InitializeComponent();
        }

        private int _id;
        private string _name;
        private string _surname;
        private string _username;
        private string _email;
        private string _password;
        private int _role;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Names
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public void SetValues()
        {
            role.Text = userService.SelectRole(Role);
            email.Text = Email;
            surnameName.Text = Names + " " + Surname;
            uName.Text = UserName;
            uId.Text = Id.ToString();
        }

        public void DeleteObject(object sender, EventArgs e)
        {
            userService.delete(Id);
        }
    }
}
