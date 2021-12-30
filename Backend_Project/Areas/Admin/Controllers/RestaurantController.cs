using Backend_Project.Data;
using Backend_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RestaurantController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public RestaurantController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.Restaurants.Include(f=>f.Features)
                .Include(r=>r.Reviews)
                .Include(m=>m.Menus).ToList());
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                if ((model.ProfilPicture.ContentType== "image/jpeg" && model.CoverImage.ContentType == "image/jpeg") || (model.ProfilPicture.ContentType == "image/png" && model.CoverImage.ContentType == "image/png"))
                {
                    string profilPictureFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ProfilPicture.FileName;
                    string profilPictureFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", profilPictureFileName);
                    string coverImageFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.CoverImage.FileName;
                    string coverImageFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", coverImageFileName);

                    using (var stream = new FileStream(profilPictureFilePath, FileMode.Create))
                    {
                        model.ProfilPicture.CopyTo(stream);
                    }
                    using (var stream = new FileStream(coverImageFilePath, FileMode.Create))
                    {
                        model.CoverImage.CopyTo(stream);
                    }
                    model.ProfilPictureName = profilPictureFileName;
                    model.CoverImageName = coverImageFileName;
                    _context.Restaurants.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    return View(model);
                }
            }
            ModelState.AddModelError("", "All section is required");
            return View(model);
        }

        public IActionResult Update(int id)
        {
            return View(_context.Restaurants.Include(f => f.Features)
                .Include(r => r.Reviews)
                .Include(m => m.Menus)
                .FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult Update(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                if (model.ProfilPicture.ContentType == "image/jpeg" && model.CoverImage.ContentType == "image/jpeg" || model.ProfilPicture.ContentType == "image/png" && model.CoverImage.ContentType == "image/png")
                {
                    string profilPictureFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ProfilPicture.FileName;
                    string profilPictureFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", profilPictureFileName);
                    string coverImageFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.CoverImage.FileName;
                    string coverImageFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", coverImageFileName);

                    using (var stream = new FileStream(profilPictureFilePath, FileMode.Create))
                    {
                        model.ProfilPicture.CopyTo(stream);
                    }
                    using (var stream = new FileStream(coverImageFilePath, FileMode.Create))
                    {
                        model.CoverImage.CopyTo(stream);
                    }
                    model.ProfilPictureName = profilPictureFileName;
                    model.CoverImageName = coverImageFileName;

                    _context.Restaurants.Update(model);
                    _context.SaveChanges();
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    return View(model);
                }
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Restaurant restaurant = _context.Restaurants.Find(id);
            _context.Restaurants.Remove(restaurant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
