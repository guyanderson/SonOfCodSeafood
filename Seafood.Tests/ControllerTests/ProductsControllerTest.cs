using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Controllers;
using SonOfCodSeafood.Models;
using Xunit;

namespace Seafood.Tests.ControllerTests
{
    public class ProductsControllerTest
    {

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ProductController controller = new ProductController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

    }
}
