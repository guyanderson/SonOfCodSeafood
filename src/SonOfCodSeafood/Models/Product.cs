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
        public string Description { get; set; }
        public byte[] Img { get; set; }


        public Product()
        {
        }

        public Product(string name, string description, Byte[] img)
        {
            Name = name;
            Description = description;
            Img = img;
        }

    }
}
