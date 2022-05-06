using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicMS.Interfaces
{
    interface IWindowState
    {
        void CloseWindow();

        void OpenDashBoard(Form form);

        void OpenMedicines(Form form);

        void OpenPets(Form form);

        void OpenWiki(Form form);

        void OpenUserAdministration(Form form);

        void OpenCalendar(Form form);

        void Minimalize(Form form);

        void LogOut(Form form);
    }
}
