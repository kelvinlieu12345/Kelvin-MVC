using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcArt.Models
{
    public class Art
    {
        public int Id { get; set; }
        public string name { get; set; }

        [DataType(DataType.Date)]
        public DateTime dayBought { get; set; }

        public string style { get; set; }
        public decimal Price{ get; set; }
    }
}
