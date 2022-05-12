using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;
using VetClinicMS.Services;
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class Medicines : Form
    {
        readonly MedicineService medicineService = new MedicineService();
        readonly WindowState windowState = new WindowState();
        readonly UserService userService = new UserService();

        public List<MedicineModel> medicines = null;

        public Medicines()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;

            if (!userService.checkUserAccess())
            {
                this.guna2Button5.Hide();
                this.pictureBox5.Hide();
            }

            this.LoadUserControls();
        }

        private void LoadUserControls()
        {
            medicineService.fetchMedicines(this, null, false);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                NameValueCollection list = new NameValueCollection();
                list["id"] = medId.Text;
                list["category"] = category.Text;
                list["name"] = name.Text;
                list["description"] = description.Text;
                list["price"] = price.Text;
                list["stock"] = stock.Text;

                if (medId.Text == "")
                {
                    medicineService.create(list);
                }
                else
                {
                    medicineService.update(list);
                }
            }
            catch (Exception ex)
            {
                label8.Text = ex.Message;
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
            label8.Text = "";
        }

        public void UserControl_Click(object sender, EventArgs e)
        {
            MedicinControl medicine = (MedicinControl)sender;
            name.Text = medicine.medicine;
            category.Text = medicine.category;
            stock.Text = medicine.stock.ToString();
            description.Text = medicine.description;
            medId.Text = medicine.id.ToString();
            price.Text = medicine.price.ToString();
        } 

        private void CloseWindow(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenUserAdministration(object sender, EventArgs e)
        {
            windowState.OpenUserAdministration(this);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            windowState.OpenWiki(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.OpenPets(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.OpenCalendar(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            windowState.OpenDashBoard(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            windowState.Minimalize(this);
        }

        private void Available_Click(object sender, EventArgs e)
        {
            medicineService.fetchMedicines(this, searchBox.Text, true);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadUserControls();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            medicineService.fetchMedicines(this, searchBox.Text, false);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            windowState.LogOut(this);
        }
    }
}
