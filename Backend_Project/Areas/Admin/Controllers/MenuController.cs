using Backend_Project.Data;
using Backend_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly AppDbContext _context;

        public MenuController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Menus.Include(r => r.Restaurant).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Restaurant = _context.Restaurants.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Menu model)
        {
            if (ModelState.IsValid)
            {
                _context.Menus.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int id)
        {
            ViewBag.Restaurant = _context.Restaurants.ToList();
            return View(_context.Menus.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Menu model)
        {
            if (ModelState.IsValid)
            {
                _context.Menus.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                HttpContext.Session.SetString("NullIdError", "Id can not be null");
                return RedirectToAction("Index");
            }

            Menu menu = _context.Menus.Find(id);
            if (menu==null)
            {
                HttpContext.Session.SetString("NullDataError", "Can not found the data");
                return RedirectToAction("Index");
            }
            _context.Menus.Remove(menu);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
