using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "datetime2")]
        public DateTime CreateAt { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime UpdatedAt { get; set; }

    }
}
