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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
