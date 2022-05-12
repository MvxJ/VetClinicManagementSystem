using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicMS.Models;

namespace VetClinicMS.Services
{
    public class DataService
    {
        readonly UserService userService = new UserService();
        public string password = "Qwertyuiop2022!";
        public void seedData()
        {
            using (var database = new ModelContext())
            {
                if (!database.Users.Any())
                {
                    UserModel user = new UserModel();
                    user.role = userService.GetRoleId("Local Admins");
                    user.name = "Admin";
                    user.surname = "";
                    user.username = "admin";
                    user.email = "admin@admin.pl";
                    user.password = BCrypt.Net.BCrypt.HashPassword(password);

                    UserModel user2 = new UserModel();
                    user2.role = userService.GetRoleId("Local Admins");
                    user2.name = "Terri";
                    user2.surname = "Riddle";
                    user2.username = "doctor.Riddle";
                    user2.email = "terri.riddle@clinic.com";
                    user2.password = BCrypt.Net.BCrypt.HashPassword(password);

                    database.Users.Add(user);
                    database.Users.Add(user2);
                }

                if (!database.Articles.Any())
                {
                    ArticleModel article = new ArticleModel();
                    article.Author = "Terri Riddle";
                    article.Title = "The Inner Life of Cats";
                    article.Short = "If you have ever wondered why your cat behaves the way it does, wonder no more";
                    article.Content = "Cats and dogs belong to a group of mammals known as Carnivora, and the wild ancestors of both species" +
                        " dined primarily on meat. Recent DNA analyses indicate that over the course of their evolution," +
                        " dogs have acquired more copies of the so-called amylase gene, which makes an enzyme that helps " +
                        "to break down starch. Having more copies of this gene has allowed dogs to eat a more omnivorous diet.";
                    article.CreateAt = DateTime.Now;
                    article.UpdatedAt = DateTime.Now;

                    ArticleModel article2 = new ArticleModel();
                    article2.Author = "Maya Wei-Haas";
                    article2.Title = "Dogs Are Even More Like Us Than We Thought";
                    article2.Short = "For one, canines shun people who are mean to their owners, a new study says.";
                    article2.Content = "Social eavesdropping—or people-watching—is central to human social interactions, since it allows us to " +
                        "figure out who's nice and who's mean.According to a study published in August in the journal Animal Behaviour, our " +
                        "dogs listen in too. (Read 'Animal Minds' in National Geographic magazine.) In a new study, scientists tested 54 " +
                        "dogs that each watched their owners struggle to retrieve a roll of tape from a container.";
                    article2.CreateAt = DateTime.Now;
                    article2.UpdatedAt = DateTime.Now;

                    ArticleModel article3 = new ArticleModel();
                    article3.Author = "Maya Wei-Haas";
                    article3.Title = "Cats Like People! (Some People, Anyway)";
                    article3.Short = "Despite apparent aloofness, cats are social creatures capable of relationships with people, a new study suggests.";
                    article3.Content = "Other researchers have found that cats are sensitive to human emotion and mood, and that cats know their " +
                        "names.Scientists had arrived at conflicting findings about whether cats form attachments to their owners, however, " +
                        "so Dr.Vitale and her colleagues designed a study to more explicitly test the hypothesis.";
                    article3.CreateAt = DateTime.Now;
                    article3.UpdatedAt = DateTime.Now;

                    database.Articles.Add(article3);
                    database.Articles.Add(article2);
                    database.Articles.Add(article);
                }

                if (!database.PetList.Any())
                {
                    PetsModel pet = new PetsModel();
                    pet.pet = "Cat";
                    pet.name = "Miki";
                    pet.onwer = "Johnny Foster";
                    pet.note = "After last visit get tabs for better sleep";
                    pet.age = 4;
                    pet.image = "";

                    PetsModel pet2 = new PetsModel();
                    pet2.pet = "Dog";
                    pet2.name = "Max";
                    pet2.onwer = "Johnny Foster";
                    pet2.note = "Everythink was ok. Must watch left arm.";
                    pet2.age = 1;
                    pet2.image = "";

                    PetsModel pet3 = new PetsModel();
                    pet3.pet = "Cat";
                    pet3.name = "Max";
                    pet3.onwer = "Cecelia Reid";
                    pet3.note = "Had problem with stomach, receipt tabs for it.";
                    pet3.age = 11;
                    pet3.image = "";

                    database.PetList.Add(pet3);
                    database.PetList.Add(pet2);
                    database.PetList.Add(pet);
                }

                if (!database.Events.Any())
                {
                    EventModel singleEvent = new EventModel();
                    singleEvent.description = "-";
                    singleEvent.email = "";
                    singleEvent.title = "Tick ​​vaccine";
                    singleEvent.to = DateTime.Now.AddHours(1);
                    singleEvent.from = DateTime.Now;
                    singleEvent.phone = "123123123";
                    singleEvent.doctorId = 2;
                    singleEvent.petId = 1;

                    EventModel singleEvent2 = new EventModel();
                    singleEvent2.description = "-";
                    singleEvent2.email = "";
                    singleEvent2.title = "Removal of bandages from a wound";
                    singleEvent2.to = DateTime.Now.AddHours(3);
                    singleEvent2.from = DateTime.Now.AddHours(2);
                    singleEvent2.phone = "321321321";
                    singleEvent2.doctorId = 2;
                    singleEvent2.petId = 2;

                    database.Events.Add(singleEvent);
                    database.Events.Add(singleEvent2);
                }

                if (!database.Medicine.Any())
                {
                    MedicineModel medicine = new MedicineModel();
                    medicine.price = 49.99F;
                    medicine.name = "Med Tabs";
                    medicine.stock = 10;
                    medicine.description = "Tabs for cats, good for young cats, helps with stomach ache";
                    medicine.category = "Cats";

                    MedicineModel medicine2 = new MedicineModel();
                    medicine2.price = 35.75F;
                    medicine2.name = "Med Tabs for Dogs";
                    medicine2.stock = 10;
                    medicine2.description = "Tabs for dogs, help after all medical treatments";
                    medicine2.category = "Dogs";

                    MedicineModel medicine3 = new MedicineModel();
                    medicine3.price = 15.23F;
                    medicine3.name = "Well Vitamins";
                    medicine3.stock = 0;
                    medicine3.description = "Vitamins for young dogs";
                    medicine3.category = "Dogs";

                    database.Medicine.Add(medicine3);
                    database.Medicine.Add(medicine2);
                    database.Medicine.Add(medicine);
                }

                database.SaveChanges();
            }
        }
    }
}
