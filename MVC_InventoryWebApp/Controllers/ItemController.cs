using MVC_InventoryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_InventoryWebApp.Controllers
{
    public class ItemController : Controller
    {

        static IList<Item> ItemList = new List<Item>{
                new Item() { ItemId = 1, ItemName = "Toaster", ItemDescription = "4-slice stainless steel toaster", ItemQuantity = 1 } ,
                new Item() { ItemId = 2, ItemName = "Coffee Maker", ItemDescription = "Programmable coffee maker", ItemQuantity = 1 } ,
                new Item() { ItemId = 3, ItemName = "Vacuum Cleaner", ItemDescription = "Cordless stick vacuum cleaner", ItemQuantity = 1 } ,
                new Item() { ItemId = 4, ItemName = "Pressure Cooker", ItemDescription = "Electric pressure cooker with multiple cooking settings", ItemQuantity = 1 } ,
                new Item() { ItemId = 5, ItemName = "Microwave", ItemDescription = "1.1 cu. ft. countertop microwave", ItemQuantity = 1 } ,
                new Item() { ItemId = 6, ItemName = "Iron", ItemDescription = "Steam iron with retractable cord", ItemQuantity = 1 } ,
                new Item() { ItemId = 7, ItemName = "Hair Dryer", ItemDescription = "Ceramic ionic hair dryer", ItemQuantity = 1 } ,
                new Item() { ItemId = 8, ItemName = "Air Purifier", ItemDescription = "HEPA air purifier with multiple filters", ItemQuantity = 1 } ,
            };


        // GET: Item
        public ActionResult Index()
        {
            //fetch items from the DB using Entity Framework here
            return View(ItemList);
        }


        /*
        //Action Method Parameters
        [HttpPost]
        public ActionResult Edit(Item std)
        {
            // update item to the database

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete item from the database whose id matches with specified id

            return RedirectToAction("Index");
        }
        */


    }
}