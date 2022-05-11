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

        public void fetchEvents(Calendar form, string searchDate)
        {
            form.eventsPanel.Controls.Clear();

            using (ModelContext database = new ModelContext())
            {
                var events = database.Events.OrderBy(e => e.from).ToList();

                if (Global.Usermode == 2)
                {
                    events = events.Where(e => e.doctorId == Global.UserId).ToList();
                }

                if (searchDate != null)
                {
                    var today = DateTime.ParseExact(searchDate, "dd.MM.yyyy", null);
                    var tomorrow = DateTime.ParseExact(searchDate, "dd.MM.yyyy", null).AddDays(1);
                    events = events.ToList().Where(e => e.from >= today && e.from <= tomorrow).ToList();
                }
                else
                {
                    var today = DateTime.Now.Date;
                    var tomorrow = today.AddDays(1).Date;

                    events = events.ToList().Where(e => e.from >= today && e.from <= tomorrow).ToList();
                }

                events.ForEach(single => {
                    EventControl eventControl = new EventControl();
                    eventControl.Id = single.id;
                    eventControl.Title = single.title;
                    eventControl.Description = single.description;
                    eventControl.FromDate = single.from;
                    eventControl.ToDate = single.to;
                    eventControl.Phone = single.phone;
                    eventControl.Email = single.email;
                    eventControl.PetId = single.petId;
                    eventControl.DoctorId = single.doctorId;
                    eventControl.Click += new System.EventHandler(form.EventControl_Click);
                    eventControl.SetValues();
                    form.eventsPanel.Controls.Add(eventControl);
                });
            }
        }

        public void fetchDoctorsAndPets(Calendar form)
        {
            using (ModelContext database = new ModelContext())
            {
                var doctors = database.Users.Where(u => u.role == 2).ToList();
                var pets = database.PetList.ToList();

                form.doctorCombo.DataSource = doctors;
                form.doctorCombo.ValueMember = "id";
                form.doctorCombo.DisplayMember = "username";

                form.petsCombo.DataSource = pets;
                form.petsCombo.ValueMember = "petId";
                form.petsCombo.DisplayMember = "name";
            }
        }

        public List<EventModel> getEvents()
        {


            using (ModelContext database = new ModelContext())
            {
                var events = database.Events.OrderBy(e => e.from).ToList();

                if (Global.Usermode == 2)
                {
                    events = events.Where(e => e.doctorId == Global.UserId).ToList();
                }

                var today = DateTime.Now.Date;
                var tomorrow = today.AddDays(1).Date;

                events = events.ToList().Where(e => e.from >= today && e.from <= tomorrow).ToList();

                return events;
            }
        }
    }
}
