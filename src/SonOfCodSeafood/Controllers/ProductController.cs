using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SonOfCodSeafood.Controllers
{
    public class ProductController : Controller
    {

        private SonOfCodSeafoodDbContext _db;

        public ProductController(SonOfCodSeafoodDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisProduct = _db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

    }
}
