﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SonOfCodSeafood.Models
{
    public class SonOfCodSeafoodDbContext : DbContext
    {

        public SonOfCodSeafoodDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Recipient> Recipients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SonOfCodSeafood;integrated security=True");
        }

        public SonOfCodSeafoodDbContext(DbContextOptions<SonOfCodSeafoodDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
