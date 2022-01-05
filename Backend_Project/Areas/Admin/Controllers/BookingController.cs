using Backend_Project.Data;
using Backend_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingController : Controller
    {
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Bookings.Include(d=>d.Restaurant).ToList());
        }

         public IActionResult Delete(int id)
         {
            Booking booking = _context.Bookings.Find(id);
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
            return RedirectToAction("Index");
         }
    }
}
