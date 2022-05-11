using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Services
{
    public class PetsService : ICrudOperation
    {
        public void create(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {
                var pet = new PetsModel()
                {
                    onwer = list["owner"],
                    age = Int32.Parse(list["age"]),
                    note = list["note"],
                    name = list["name"],
                    pet = list["pet"],
                    image = list["image"]
                };

                database.PetList.Add(pet);
                database.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (ModelContext database = new ModelContext())
            {
                var pet = database.PetList.First(c => c.petId == id);
                if (pet != null)
                {
                    database.PetList.Remove(pet);
                    database.SaveChanges();

                }
            }
        }

        public void update(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {
                int id = Int32.Parse(list["id"]);
                var pet = database.PetList.Where(p => p.petId == id).First();

                pet.onwer = list["owner"];
                pet.age = Int32.Parse(list["age"]);
                pet.note = list["note"];
                pet.name = list["name"];
                pet.pet = list["pet"];
                pet.image = list["image"];

                database.SaveChanges();
            }
        }

        public void fetchPets(Pets form, string searchText)
        {
            using (ModelContext database = new ModelContext())
            {
                form.panel1.Controls.Clear();
                var petsList = database.PetList.ToList();

                if (searchText != null)
                {
                    petsList = petsList.Where(a => a.name == searchText || a.onwer == searchText || a.pet == searchText).ToList();
                }

                form.pets = petsList;

                petsList.ForEach(pet => {
                    PetsControl petControl = new PetsControl();
                    petControl.note = pet.note;
                    petControl.pet = pet.pet;
                    petControl.age = pet.age;
                    petControl.name = pet.name;
                    petControl.owner = pet.onwer;
                    petControl.id = pet.petId;
                    petControl.image = pet.image;
                    petControl.SetValues();
                    petControl.Click += new System.EventHandler(form.PetsControl_Click);
                    form.panel1.Controls.Add(petControl);
                });
            }
        }
    }
}
