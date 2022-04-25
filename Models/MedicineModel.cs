using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Models
{
    public class MedicineModel
    {
        [Key]
        public int id { get; set; }
        [StringLength(255)]
        public string name { get; set; }
        [StringLength(255)]
        public string category { get; set; }
        [StringLength(255)]
        public string description { get; set; }
        public float price { get; set; }
        public int stock { get; set; }
    }
}
