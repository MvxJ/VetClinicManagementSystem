using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;
using VetClinicMS.UserControlls;

namespace VetClinicMS.Services
{
    public class MedicineService: ICrudOperation
    {
        public void update(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {
                int id = Int32.Parse(list["id"]);
                var med = database.Medicine.Where(p => p.id == id).First();

                med.name = list["name"];
                med.description = list["description"];
                med.category = list["category"];
                med.price = float.Parse(list["price"]);
                med.stock = Int32.Parse(list["stock"]);

                database.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (ModelContext database = new ModelContext())
            {
                var medicine = database.Medicine.First(c => c.id == id);
                if (medicine != null)
                {
                    database.Medicine.Remove(medicine);
                    database.SaveChanges();
                } else
                {
                    throw new Exception("Medicine not found!");
                }
            }
        }

        public void create(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {
                var med = new MedicineModel()
                {
                    category = list["category"],
                    name = list["name"],
                    description = list["description"],
                    price = float.Parse(list["price"]),
                    stock = Int32.Parse(list["stock"])
                };

                database.Medicine.Add(med);
                database.SaveChanges();
            }
        }

        public void fetchMedicines(Medicines form, string searchQuery, Boolean available)
        {
            using (ModelContext database = new ModelContext())
            {
                var medicines = database.Medicine.ToList();
                form.medicinesPanel.Controls.Clear();
                
                if (searchQuery != null) {
                    medicines = medicines.ToList().Where(a => a.name.Contains(searchQuery) || a.category.Contains(searchQuery)).ToList();
                }

                if (available == true)
                {
                    medicines = medicines.ToList().Where(a => a.stock > 0).ToList();
                }

                form.medicines = medicines;

                medicines.ForEach(med => {
                    MedicinControl medicineControl = new MedicinControl();
                    medicineControl.id = med.id;
                    medicineControl.medicine = med.name;
                    medicineControl.category = med.category;
                    medicineControl.description = med.description;
                    medicineControl.stock = med.stock;
                    medicineControl.price = med.price;
                    medicineControl.SetValues();
                    medicineControl.Click += new System.EventHandler(form.UserControl_Click);
                    form.medicinesPanel.Controls.Add(medicineControl);
                });
            }
        }
    }
}
