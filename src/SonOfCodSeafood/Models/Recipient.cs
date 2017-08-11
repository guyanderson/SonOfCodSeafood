using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SonOfCodSeafood.Models
{
    public class Recipient
    {
        [Key]
        public string email { get; set; }
    }
}
