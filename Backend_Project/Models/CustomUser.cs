using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class CustomUser 
    {       
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string MyUsername { get; set; }

        [MaxLength(30)]
        public string Password { get; set; }
    }
}
