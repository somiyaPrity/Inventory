using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OST_inventory_B_2.Models
{
    public class Account
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}