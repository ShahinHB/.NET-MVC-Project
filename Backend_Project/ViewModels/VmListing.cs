using Backend_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.ViewModels
{
    public class VmListing
    {
        public List<Restaurant> Restaurants { get; set; }
        public Setting Setting { get; set; }
    }
}
