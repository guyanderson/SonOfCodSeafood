using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCodSeafood.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public byte[] Img { get; set; }


        public Product()
        {
        }

        public Product(string name, decimal price, string description,string details, Byte[] img)
        {
            Name = name;
            Price = price;
            Description = description;
            Details = details;
            Img = img;
        }

    }
}
