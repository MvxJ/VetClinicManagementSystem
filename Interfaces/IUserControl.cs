using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Interfaces
{
    public interface IUserControl
    {
        void SetValues();

        void DeleteObject(object sender, EventArgs e);
    }
}
