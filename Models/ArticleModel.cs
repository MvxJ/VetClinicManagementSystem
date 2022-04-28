using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicMS.Models
{
    public class ArticleModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        public string UpdateBy { get; set; }
        public string Content { get; set; }
        [StringLength(255)]
        public string Short { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }

    }
}
