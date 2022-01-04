using Backend_Project.Data;
using Backend_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Setting> model = _context.Settings.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Setting model)
        {
            if (ModelState.IsValid)
            {
                if (model.Logo.ContentType == "image/jpeg" || model.Logo.ContentType == "image/png" || model.Logo.ContentType == "image/jpg")
                {
                    if (model.BannerImage.ContentType == "image/jpeg" || model.BannerImage.ContentType == "image/png" || model.BannerImage.ContentType == "image/jpg")
                    {
                        string logoFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.Logo.FileName;
                        string logoFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", logoFileName);
                        string bannerImageFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.BannerImage.FileName;
                        string bannerImageFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", bannerImageFileName);

                        using (var stream = new FileStream(logoFilePath, FileMode.Create))
                        {
                            model.Logo.CopyTo(stream);
                        }
                        using (var stream = new FileStream(bannerImageFilePath, FileMode.Create))
                        {
                            model.BannerImage.CopyTo(stream);
                        }
                        model.LogoName = logoFileName;
                        model.BannerImageName = bannerImageFileName;
                        _context.Settings.Add(model);
                        _context.SaveChanges();


                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        return View(model);
                    }
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
            return View(_context.Settings.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (ModelState.IsValid) 
            {
                if (model.Logo.ContentType == "image/jpeg" || model.Logo.ContentType == "image/png" || model.Logo.ContentType == "image/jpg")
                {
                    if (model.BannerImage.ContentType == "image/jpeg" || model.BannerImage.ContentType == "image/png" || model.BannerImage.ContentType == "image/jpg")
                    {
                        string logoFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.Logo.FileName;
                        string logoFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", logoFileName);
                        string bannerImageFileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.BannerImage.FileName;
                        string bannerImageFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", bannerImageFileName);

                        using (var stream = new FileStream(logoFilePath, FileMode.Create))
                        {
                            model.Logo.CopyTo(stream);
                        }
                        using (var stream = new FileStream(bannerImageFilePath, FileMode.Create))
                        {
                            model.BannerImage.CopyTo(stream);
                        }
                        model.LogoName = logoFileName;
                        model.BannerImageName = bannerImageFileName;
                        _context.Settings.Update(model);
                        _context.SaveChanges();


                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        return View(model);
                    }
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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                HttpContext.Session.SetString("NullIdError", "Id can not be null");
                return RedirectToAction("Index");
            }

            Setting setting = _context.Settings.Find(id);
            if (setting == null)
            {
                HttpContext.Session.SetString("NullDataError", "Can not found the data");
                return RedirectToAction("Index");
            }
            _context.Settings.Remove(setting);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

