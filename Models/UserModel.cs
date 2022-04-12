using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Models
{
    public class UserModel
    {
        [Key]
        public int id { get; set; }
        [StringLength(255)]
        public string username { get; set; }
        [StringLength(255)]
        public string password { get; set; }
        [StringLength(255)]
        public string name { get; set; }
        [StringLength(255)]
        public string surname { get; set; }
        public int role { get; set; }
        [StringLength(255)]
        public string email { get; set; }
    }
}
