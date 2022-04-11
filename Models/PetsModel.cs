using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Models
{
    public class PetsModel
    {
        [Key]
        public int petId { get; set; }

        [StringLength(255)]
        public string name { get; set; }
        [StringLength(255)]
        public string onwer { get; set; }
        [StringLength(255)]
        public string note { get; set; }
        public int age { get; set; }
        [StringLength(255)]
        public string pet { get; set; }

        [StringLength(255)]
        public string image { get; set; }
    }
}
