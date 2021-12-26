using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class RestaurantDetail
    {
        [Key]
        public int Id { get; set; }

        public string Location { get; set; }
        public string About { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Feature> Features { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public RestaurantDetail Restaurant { get; set; }

        [ForeignKey("Director")]
        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
