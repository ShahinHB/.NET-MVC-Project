using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string LogoName { get; set; }
        [NotMapped]
        public IFormFile Logo { get; set; }
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        public string Address { get; set; }

        [MaxLength(250)]
        public string BannerImageName { get; set; }
        [NotMapped]
        public IFormFile BannerImage { get; set; }
    }
}
