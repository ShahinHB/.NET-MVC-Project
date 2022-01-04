using Backend_Project.Data;
using Backend_Project.Models;
using Backend_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Controllers
{
    public class ListingController : Controller
    {
        private readonly AppDbContext _context;

        public ListingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmListing vmListing = new VmListing();
            vmListing.Restaurants = _context.Restaurants.ToList();
            vmListing.Setting = _context.Settings.FirstOrDefault();

            return View(vmListing);
        }
        public IActionResult Details(int id)
        {
            VmRestaurantDetails vmRestaurantDetails = new VmRestaurantDetails();
            vmRestaurantDetails.Restaurant = _context.Restaurants.Include(r => r.RestaurantToFeatures).ThenInclude(f => f.Feature)
                .Include(p => p.Reviews)
                .Include(m => m.Menus).FirstOrDefault(i => i.Id == id);
            vmRestaurantDetails.Review = _context.Reviews.FirstOrDefault(r => r.RestaurantId == id);

            return View(vmRestaurantDetails);
        }

        [HttpPost]
        public IActionResult Review(Review model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                _context.Reviews.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Details", "Listing", new { id = model.RestaurantId });
            }

            return View(model);
        }

    }
}
