using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Models;

namespace VetClinicMS
{
    public partial class PetsControl : UserControl
    {
        public PetsControl()
        {
            InitializeComponent();
        }

        private string _name;
        private string _owner;
        private string _note;
        private string _pet;
        private int _age;
        private int _id;
        private string _image;

        public string name {
            get { return _name; }
            set { _name = value; } 
        }
        public string image
        {
            get { return _image; }
            set { _image = value; }
        }

        public string owner {
            get { return _owner; }
            set { _owner = value; }
        }

        public int age{
            get { return _age; }
            set { _age = value; }
        }

        public string note {
            get { return _note; }
            set { _note = value; }
        }

        public string pet {
            get { return _pet; }
            set { _pet = value; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void setValues()
        {
            label1.Text = name;
            label2.Text = age.ToString();
            label3.Text = owner;
            label4.Text = pet;
            petID.Text = id.ToString();
            pictureBox1.ImageLocation = image;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (ModelContext database = new ModelContext())
            {
                int id = Int32.Parse(petID.Text);
                var pet = database.PetList.First(c => c.petId == id);
                if (pet != null)
                {
                    database.PetList.Remove(pet);
                    database.SaveChanges();

                }
            }
        }
    }
}
