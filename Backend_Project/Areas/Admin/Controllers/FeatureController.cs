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
    public class FeatureController : Controller
    {
        private readonly AppDbContext _context;

        public FeatureController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Feature> model = _context.Features.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Feature model)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "menim errorum");
            return View(model);
        }

        public IActionResult Update(int id)
        {
            return View(_context.Features.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Feature model)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Update(model);
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

            Feature feature = _context.Features.Find(id);
            if (feature == null)
            {
                HttpContext.Session.SetString("NullDataError", "Can not found the data");
                return RedirectToAction("Index");
            }
            _context.Features.Remove(feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
