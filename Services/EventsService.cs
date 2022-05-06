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
    internal class EventsService : ICrudOperation
    {
        public void create(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {

                var newEvent = new EventModel()
                {
                    title = list["title"],
                    description = list["description"],
                    email = list["email"],
                    phone = list["phone"],
                    petId = Int32.Parse(list["petId"]),
                    doctorId = Int32.Parse(list["doctorId"]),
                    from = DateTime.Parse(list["from"]),
                    to = DateTime.Parse(list["to"])
                };

                database.Events.Add(newEvent);
                database.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (ModelContext database = new ModelContext())
            {
                var events = database.Events.First(c => c.id == id);
                if (events != null)
                {
                    database.Events.Remove(events);
                    database.SaveChanges();
                }
            }
        }

        public void update(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {
                int id = Int32.Parse(list["id"]);
                var singleEvent = database.Events.Where(p => p.id == id).First();

                singleEvent.title = list["title"];
                singleEvent.description = list["description"];
                singleEvent.email = list["email"];
                singleEvent.phone = list["phone"];
                singleEvent.doctorId = Int32.Parse(list["doctorId"]);
                singleEvent.petId = Int32.Parse(list["petId"]);
                singleEvent.from = DateTime.Parse(list["from"]);
                singleEvent.to = DateTime.Parse(list["to"]);

                database.SaveChanges();
            }
        }
    }
}
