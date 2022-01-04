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
            return View(_context.Restaurants.Include(f => f.RestaurantToFeatures).ThenInclude(r => r.Feature)
                .Include(r => r.Reviews)
                .Include(m => m.Menus)
                .ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Features = _context.Features.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                if ((model.ProfilPicture.ContentType == "image/jpeg" && model.CoverImage.ContentType == "image/jpeg") || (model.ProfilPicture.ContentType == "image/png" && model.CoverImage.ContentType == "image/png"))
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


                    foreach (var item in model.RestaurantToFeaturesId)
                    {
                        RestaurantToFeature restaurantToFeature = new RestaurantToFeature();
                        restaurantToFeature.FeatureId = item;
                        restaurantToFeature.RestaurantId = model.Id;
                        _context.RestaurantToFeatures.Add(restaurantToFeature);
                        _context.SaveChanges();
                    }

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
            Restaurant restaurant = _context.Restaurants.FirstOrDefault(i => i.Id == id);
            restaurant.RestaurantToFeaturesId = _context.RestaurantToFeatures.Where(fr => fr.RestaurantId == id).Select(r => r.FeatureId).ToList();


            ViewBag.Features = _context.Features.ToList();
            return View(_context.Restaurants.Find(id));
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

                    List<RestaurantToFeature> restaurantToFeatures = _context.RestaurantToFeatures.Where(fr => fr.RestaurantId == model.Id).ToList();

                    foreach (var item in restaurantToFeatures)
                    {
                        _context.RestaurantToFeatures.Remove(item);
                    }
                    _context.SaveChanges();

                    foreach (var item in model.RestaurantToFeaturesId)
                    {
                        RestaurantToFeature restaurantToFeature = new RestaurantToFeature();
                        restaurantToFeature.FeatureId = item;
                        restaurantToFeature.RestaurantId = model.Id;
                        _context.RestaurantToFeatures.Add(restaurantToFeature);
                    }
                    _context.SaveChanges();
                    return RedirectToAction("Index");
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
