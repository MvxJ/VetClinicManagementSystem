using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicMS
{
    public class User
    {
        public void LogOut(Form form)
        {
            Global.Surname = "";
            Global.Username = "";
            Global.Usermode = 0;
            LoginForm login = new LoginForm();
            login.Show();
            form.Hide();
        }
    }
}
