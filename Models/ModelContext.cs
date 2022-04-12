﻿using System;
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
    }
}
