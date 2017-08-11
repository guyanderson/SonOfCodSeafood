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
    public class NewsLetterController : Controller
    {

        private SonOfCodSeafoodDbContext _db;

        public NewsLetterController(SonOfCodSeafoodDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Recipient recipient)
        {
            _db.Recipients.Add(recipient);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}


