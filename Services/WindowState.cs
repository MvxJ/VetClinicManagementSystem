using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Interfaces;

namespace VetClinicMS
{
    internal class WindowState: IWindowState
    {
        public void CloseWindow()
        {
            Application.Exit();
        }

        public void OpenUserAdministration(Form form)
        {
            UserAdministration administration = new UserAdministration();
            administration.Show();
            form.Hide();
        }

        public void OpenCalendar(Form form)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            form.Hide();
        }
        
        public void OpenPets(Form form)
        {
            Pets pets = new Pets();
            pets.Show();
            form.Hide();
        }

        public void OpenMedicines(Form form)
        {
            Medicines medicines = new Medicines();
            medicines.Show();
            form.Hide();
        }

        public void OpenDashBoard(Form form)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            form.Hide();
        }

        public void OpenWiki(Form form)
        {
            Wiki wiki = new Wiki();
            wiki.Show();
            form.Hide();
        }

        public void Minimalize(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void LogOut(Form form)
        {
            UserService userService = new UserService();
            userService.LogOut(form);
        }
    }
}
