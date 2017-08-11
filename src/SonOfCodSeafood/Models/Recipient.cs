using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCodSeafood.Models
{
    [Table("Recipients")]
    public class Recipient
    {
        [Key]
        public int RecipientId { get; set; }
        public string email { get; set; }
    }
}
