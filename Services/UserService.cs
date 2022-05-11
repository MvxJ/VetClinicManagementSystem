using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;
using VetClinicMS.UserControlls;

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
            using (var database = new ModelContext())
            {
                var user = new UserModel()
                {
                    username = list["userName"],
                    name = list["name"],
                    surname = list["surname"],
                    role = Int32.Parse(list["role"]),
                    email = list["email"],
                    password = list["password"]
                };

                database.Users.Add(user);
                database.SaveChanges();
            }
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
            using (var database = new ModelContext())
            {
                int id = Int32.Parse(list["id"]);
                var user = database.Users.Where(p => p.id == id).First();

                user.username = list["userName"];
                user.name = list["name"];
                user.surname = list["surname"];
                user.role = Int32.Parse(list["role"]);
                user.email = list["email"];

                if (list["password"] != "")
                {
                    user.password = list["password"];
                }

                database.SaveChanges();
            }
        }

        public void fetchUsers(UserAdministration form, string searchText)
        {
            using (ModelContext database = new ModelContext())
            {
                form.panel1.Controls.Clear();
                var userList = database.Users.ToList();

                if (searchText != null)
                {
                    userList = userList.Where(a => 
                        a.name == searchText 
                        || a.surname == searchText
                        || a.email == searchText
                        || a.username == searchText
                    ).ToList();
                }

                form.users = userList;

                userList.ForEach(user => {
                    AdministrationUserControl userControl = new AdministrationUserControl();
                    userControl.Password = user.password;
                    userControl.Surname = user.surname;
                    userControl.Names = user.name;
                    userControl.UserName = user.username;
                    userControl.Email = user.email;
                    userControl.Id = user.id;
                    userControl.Role = user.role;
                    userControl.SetValues();
                    userControl.Click += new System.EventHandler(form.UserControl_Click);
                    form.panel1.Controls.Add(userControl);
                });


            }
        }
    }
}
