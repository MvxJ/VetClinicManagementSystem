using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Models
{
    public class EventModel
    {
        [Key]
        public int id { get; set; }
        [StringLength(255)]
        public string title { get; set; }
        public int doctorId { get; set; }
        public int petId { get; set; }
        [StringLength(255)]
        public string phone { get; set; }
        [StringLength(255)]
        public string email { get; set; }
        [StringLength(255)]
        public string description { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime from { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime to { get; set; }
    }
}
