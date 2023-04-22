using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_InventoryWebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Quantity { get; set; }

    }
}