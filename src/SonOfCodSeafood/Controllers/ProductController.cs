﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.EntityFrameworkCore;

namespace SonOfCodSeafood.Controllers
{
    public class ProductController : Controller
    {

        private SonOfCodSeafoodDbContext db = new SonOfCodSeafoodDbContext();

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

    }
}
