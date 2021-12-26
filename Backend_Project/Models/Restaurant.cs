using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }
        public string Address { get; set; }

        [MaxLength(250)]
        public string ProfilPictureName { get; set; }
        [NotMapped]
        public IFormFile ProfilPicture { get; set; }

        [MaxLength(250)]
        public string CoverImageName { get; set; }
        [NotMapped]
        public IFormFile CoverImage { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        [MaxLength(30)]
        public string Status { get; set; }

        [ForeignKey("RestaurantDetail")]
        public int RestaurantId { get; set; }
        public RestaurantDetail RestaurantDetail { get; set; }

    }
}
