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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBlog vmBlog = new VmBlog();
            vmBlog.Blogs = _context.Blogs.ToList();
            vmBlog.Setting = _context.Settings.FirstOrDefault();

            return View(vmBlog);
        }
        public IActionResult Details(int id)
        {
            VmBlogDetails vmBlogDetails = new VmBlogDetails();
            vmBlogDetails.Blog = _context.Blogs.Include(c => c.Comments).FirstOrDefault(i => i.Id == id);
            vmBlogDetails.Comment = _context.Comments.FirstOrDefault(b => b.BlogId == id);
            return View(vmBlogDetails);
        }

        [HttpPost]
        public IActionResult Comment(Comment model)
        {
            if (ModelState.IsValid)
            {
                _context.Comments.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = model.BlogId });
            }

            return View(model);
        }
    }
}
