using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCodSeafood.Models
{
    [Table("Pictures")]
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        public byte[] Img { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public Picture()
        {
        }

        public Picture(Byte[] img)
        {
            Img = img;
        }


    }
}