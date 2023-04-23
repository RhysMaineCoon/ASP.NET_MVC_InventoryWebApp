using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_InventoryWebApp.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public String ItemName { get; set; }
        public String ItemDescription { get; set; }
        public int ItemQuantity { get; set; }

       
    }
}