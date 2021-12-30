using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
