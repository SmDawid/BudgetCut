using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTemplate.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        [Column("ServiceDuration")]
        public int Duration { get; set; }
        public int Price { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string ImageFile { get; set; }
    }

}
