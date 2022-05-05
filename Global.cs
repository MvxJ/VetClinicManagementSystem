using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS
{
    static class Global
    {
        private static string _Username = "";

        private static string _Surname = "";

        private static int _Usermode = 0;

        private static int _UserId;

        public static string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public static string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        public static int Usermode
        {
            get { return _Usermode; }
            set { _Usermode = value; }
        }

        public static string UserBanner
        {
            get { return _Username + " " + _Surname; }
        }

        public static int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }
}
