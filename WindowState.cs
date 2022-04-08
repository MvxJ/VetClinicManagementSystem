using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicMS
{
    internal class WindowState
    {
        public void openAdministration(Form form)
        {
            UserAdministration administration = new UserAdministration();
            administration.Show();
            form.Hide();
        }

        public void openCalendar(Form form)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            form.Hide();
        }

        public void openPets(Form form)
        {
            Pets pets = new Pets();
            pets.Show();
            form.Hide();
        }

        public void openMedicines(Form form)
        {
            Medicines medicines = new Medicines();
            medicines.Show();
            form.Hide();
        }

        public void openDashboard(Form form)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            form.Hide();
        }

        public void openWiki(Form form)
        {
            Wiki wiki = new Wiki();
            wiki.Show();
            form.Hide();
        }
    }
}
