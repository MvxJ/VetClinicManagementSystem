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

namespace VetClinicMS.UserControlls
{
    public partial class MedicinControl : UserControl
    {
        public MedicinControl()
        {
            InitializeComponent();
        }

        private string _medicine;
        private string _category;
        private string _description;
        private int _id;
        private int _stock;
        private float _price;

        public string medicine
        {
            set { _medicine = value; }
            get { return _medicine; }
        }

        public string category
        {
            set { _category = value; }
            get { return _category; }
        }
        public string description
        {
            set { _description = value; }
            get {  return _description; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public float price
        {
            get { return _price;  }
            set { _price = value; }
        }

        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public void setValues()
        {
            textMedicine.Text = "Name: " + medicine;
            textCategory.Text = "Category: " + category;
            textStock.Text = "Stock: " + stock.ToString();
            textDescription.Text = "Descripotion: " + description;
            textId.Text = id.ToString();
            textPrice.Text = "Pirce: " + price.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (ModelContext database = new ModelContext())
            {
                int id = Int32.Parse(textId.Text);
                var medicine = database.Medicine.First(c => c.id == id);
                if (medicine != null)
                {
                    database.Medicine.Remove(medicine);
                    database.SaveChanges();
                }
            }
        }
    }
}
