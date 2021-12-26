using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public RestaurantDetail RestaurantDetail { get; set; }
    }
}
