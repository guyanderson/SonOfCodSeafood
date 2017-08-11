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

        public IActionResult Edit(int id)
        {
            var thisProduct = _db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _db.Entry(product).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisProduct = _db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = _db.Products.FirstOrDefault(products => products.ProductId == id);
            _db.Products.Remove(thisProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
