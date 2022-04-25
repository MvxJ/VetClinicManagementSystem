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
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class Medicines : Form
    {
        readonly WindowState windowState = new WindowState();

        List<MedicineModel> medicines = null;

        public Medicines()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;
            this.LoadUserControls();
        }

        private void LoadUserControls()
        {
            using (ModelContext database = new ModelContext())
            {
                medicinesPanel.Controls.Clear();
                var medicines = database.Medicine.ToList();
                this.medicines = database.Medicine.ToList();

                medicines.ForEach(med => {
                    MedicinControl medicineControl = new MedicinControl();
                    medicineControl.id = med.id;
                    medicineControl.medicine = med.name;
                    medicineControl.category = med.category;
                    medicineControl.description = med.description;
                    medicineControl.stock = med.stock;
                    medicineControl.price = med.price;
                    medicineControl.setValues();
                    medicineControl.Click += new System.EventHandler(this.UserControl_Click);
                    medicinesPanel.Controls.Add(medicineControl);
                });
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (medId.Text == "")
            {
                using (var database = new ModelContext())
                {
                    var med = new MedicineModel()
                    {
                        category = category.Text,
                        name = name.Text,
                        description = description.Text,
                        price = float.Parse(price.Text),
                        stock = Int32.Parse(stock.Text)
                    };

                    database.Medicine.Add(med);
                    database.SaveChanges();
                }
            }
            else
            {
                using (var database = new ModelContext())
                {
                    int id = Int32.Parse(medId.Text);
                    var med = database.Medicine.Where(p => p.id == id).First();
                    
                    med.name = name.Text;
                    med.description = description.Text;
                    med.category = category.Text;
                    med.price = float.Parse(price.Text);
                    med.stock = Int32.Parse(stock.Text);

                    database.SaveChanges();
                }
            }
        }

        private void CancelModification_Click(object sender, EventArgs e)
        {
            medId.Text = "";
            name.Text = "";
            category.Text = "";
            description.Text = "";
            stock.Text = "";
            price.Text = "";
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            MedicinControl medicine = (MedicinControl)sender;
            name.Text = medicine.medicine;
            category.Text = medicine.category;
            stock.Text = medicine.stock.ToString();
            description.Text = medicine.description;
            medId.Text = medicine.id.ToString();
            price.Text = medicine.price.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            windowState.openAdministration(this);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            windowState.openWiki(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.openPets(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.openCalendar(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            windowState.openDashboard(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Available_Click(object sender, EventArgs e)
        {
            medicinesPanel.Controls.Clear();
            this.medicines = medicines.Where(p => p.stock > 0).ToList();
            this.medicines.ForEach(med => {
                MedicinControl medicineControl = new MedicinControl();
                medicineControl.id = med.id;
                medicineControl.medicine = med.name;
                medicineControl.category = med.category;
                medicineControl.description = med.description;
                medicineControl.stock = med.stock;
                medicineControl.price = med.price;
                medicineControl.setValues();
                medicineControl.Click += new System.EventHandler(this.UserControl_Click);
                medicinesPanel.Controls.Add(medicineControl);
            });
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadUserControls();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (ModelContext database = new ModelContext())
            {
                medicinesPanel.Controls.Clear();
                string search = searchBox.Text;
                var medicines = database.Medicine.Where(a => a.name.Contains(search) || a.category.Contains(search)).ToList();
                this.medicines = database.Medicine.Where(a => a.name.Contains(search) || a.category.Contains(search)).ToList();

                medicines.ForEach(med => {
                    MedicinControl medicineControl = new MedicinControl();
                    medicineControl.id = med.id;
                    medicineControl.medicine = med.name;
                    medicineControl.category = med.category;
                    medicineControl.description = med.description;
                    medicineControl.stock = med.stock;
                    medicineControl.price = med.price;
                    medicineControl.setValues();
                    medicineControl.Click += new System.EventHandler(this.UserControl_Click);
                    medicinesPanel.Controls.Add(medicineControl);
                });
            }
        }
    }
}
