using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Interfaces
{
    internal interface ICrudOperation
    {
        void create(NameValueCollection list);

        void delete(int id);

        void update(NameValueCollection list);
    }
}
