using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicMS.UserControlls
{
    public partial class DashBoardUserControl : UserControl
    {
        public DashBoardUserControl()
        {
            InitializeComponent();
        }

        private int _petId;
        private int _doctorId;
        private int _id;
        private string _description;
        private string _title;
        private DateTime _from;
        private DateTime _to;
        private string _phone;
        private string _email;

        public int PetId
        {
            get { return _petId; }
            set { _petId = value; }
        }

        public int DoctorId
        {
            set { _doctorId = value; }
            get { return _doctorId; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime FromDate
        {
            get { return _from; }
            set { _from = value; }
        }

        public DateTime ToDate
        {
            get { return _to; }
            set { _to = value; }
        }

        public void SetValues()
        {
            fromValue.Text = FromDate.ToString();
            toValue.Text = ToDate.ToString();
            nameValue.Text = Title;
            descriptionValue.Text = Description;

            if (DateTime.Now > ToDate) {
                guna2Panel2.FillColor = Color.IndianRed;
            } else if (DateTime.Now < ToDate && DateTime.Now > FromDate) {
                guna2Panel2.FillColor = Color.LightGoldenrodYellow;
            } else {
                guna2Panel2.FillColor = Color.LightGreen;
            }
        }
    }
}
