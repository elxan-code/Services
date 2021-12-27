using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Data;

namespace WebApplication5.Areas.admin.Controllers
{
    [Area("admin")]
    public class Products : Controller

    {

        private readonly AppDbContext _context;

        public Products(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Services.Include(c => c.User).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Services.ToList();
            return View();
        }
       
    }

}