using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace SonOfCodSeafood.Controllers
{
    public class ProductController : Controller
    {

        private SonOfCodSeafoodDbContext _db = new SonOfCodSeafoodDbContext();

         public ProductController() { }
        

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
            var thisProduct = _db.Products.AsNoTracking().FirstOrDefault(products => products.ProductId == product.ProductId);
            product.Img = thisProduct.Img; //Grabs the Img from the database then replaces it before EF removes it
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, decimal price, string description, string details, IFormFile img)
        {
            byte[] newPhoto = new byte[0];
            if (img != null)
            {
                using (Stream fileStream = img.OpenReadStream())
                using (MemoryStream ms = new MemoryStream())
                {
                    fileStream.CopyTo(ms);
                    newPhoto = ms.ToArray();
                }
            }
            Product newProduct = new Product(name, price, description, details, newPhoto);
            _db.Products.Add(newProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
