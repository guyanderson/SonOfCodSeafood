using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCodSeafood.Models;
using SonOfCodSeafood.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace Seafood.Tests.ModelTests
{
    public class ProductTest
    {
        private SonOfCodSeafoodDbContext _db;

        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var product = new Product();
            product.Name = "Cod";

            //Act
            var result = product.Name;

            //Assert
            Assert.Equal("Cod", result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ViewResult indexView = new ProductController().Index() as ViewResult;


            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Product>>(result);
        }

    }
}
