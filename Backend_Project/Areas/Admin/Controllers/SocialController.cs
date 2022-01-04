using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Project.Data;
using Backend_Project.Models;

namespace Backend_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly AppDbContext _context;

        public SocialController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Social> model = _context.Socials.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            Social model = new Social();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Social model)
        {
            if (ModelState.IsValid)
            {

                _context.Socials.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "menim errorum");
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(Social model)
        {
            if (ModelState.IsValid)
            {
                _context.Socials.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Null Error");
            return View(model);
        }

        public IActionResult Delete(int id)
        {

            Social social = _context.Socials.Find(id);

            _context.Socials.Remove(social);
            _context.SaveChanges();
            return RedirectToAction("Index", "Social");
        }
    }
}
