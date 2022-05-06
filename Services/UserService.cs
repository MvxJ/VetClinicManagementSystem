using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS
{
    public class UserService: ICrudOperation
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

        public bool checkUserAccess()
        {
            if (Global.Usermode != 1)
            {
                return false;
            }

            return true;
        }

        public string SelectRole(int roleId)
        {
            string roles = "";

            switch (roleId)
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

            return roles;
        }

        public int GetRoleId(string role)
        {
            int roleId = 0;

            switch (role)
            {
                case "Local Admins":
                    roleId = 1;
                    break;
                case "Doctor":
                    roleId = 2;
                    break;
                case "Recepcionist":
                    roleId = 0;
                    break;
            }

            return roleId;
        }

        public void create(NameValueCollection list)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            using (ModelContext database = new ModelContext())
            {
                var user = database.Users.First(c => c.id == id);
                if (user != null)
                {
                    database.Users.Remove(user);
                    database.SaveChanges();

                }
            }
        }

        public void update(NameValueCollection list)
        {
            throw new NotImplementedException();
        }
    }
}
