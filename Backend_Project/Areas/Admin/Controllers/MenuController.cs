using Backend_Project.Data;
using Backend_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            List<Menu> model = _context.Menus.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
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

            ModelState.AddModelError("", "menim errorum");
            return View(model);
        }

        public IActionResult Update(int id)
        {
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

            ModelState.AddModelError("", "menim errorum");
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
