using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SonOfCodSeafood.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace SonOfCodSeafood.Controllers
{
    public class PictureController : Controller
    {

        private readonly SonOfCodSeafoodDbContext _db;


        public PictureController(SonOfCodSeafoodDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

       // [HttpPost]
       // public IActionResult Create(int id, IFormFile img)
       // {
       //     Product thisProduct = _db.Products.FirstOrDefault(x => x.ProductId == id);
       //     byte[] newPhoto = new byte[0];
        //    if (img != null)
        //    {
        //        using (Stream fileStream = img.OpenReadStream())
         //       using (MemoryStream ms = new MemoryStream())
        //        {
         //           fileStream.CopyTo(ms);
        //            newPhoto = ms.ToArray();
         //       }
         //   }
        //    Picture newPicture = new Picture(newPhoto);
         //   newPicture.ProductId = Product.productId;
         //   _db.Pictures.Add(newPicture);
         //   _db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

    }
}
