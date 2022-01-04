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
        public string Location { get; set; }
        public string About { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }

        [MaxLength(50)]
        public string DirectorName { get; set; }

        [MaxLength(20)]
        public string DirectorPhone { get; set; }

        public string DirectorMail { get; set; }

        public string DirectorWebsite { get; set; }
        public int Capacity { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<RestaurantToFeature> RestaurantToFeatures { get; set; }

        [NotMapped]
        public List<int> RestaurantToFeaturesId { get; set; }
    }
}
