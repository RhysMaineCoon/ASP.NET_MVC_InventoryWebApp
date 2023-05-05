using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_InventoryWebApp.Models
{
    public class ContactViewModel
    {
        [Required, Display(Name = "Sender Name")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required, Display(Name = "Sender Email"), EmailAddress]
        [StringLength(50, MinimumLength = 2)]
        public string Email { get; set; }

        //public string Subject { get; internal set; }

        [Required]
        [StringLength(500, MinimumLength = 2)]
        public string Message { get; set; }
       
    }

}