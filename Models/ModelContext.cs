using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=connection") { }
        public DbSet<PetsModel> PetList { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<MedicineModel> Medicine { get; set; }
        public DbSet<ArticleModel> Articles { get; set; }
        public DbSet<EventModel> Events { get; set; }
    }
}
