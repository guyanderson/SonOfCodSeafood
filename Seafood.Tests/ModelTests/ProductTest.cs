using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCodSeafood.Models;
using Xunit;

namespace Seafood.Tests.ModelTests
{
    public class ProductTest
    {

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

    }
}
