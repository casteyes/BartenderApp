using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {

        // This is used to create and add an Id to the drinks when they are added to Orders List
        private static int id = 0;


        // This list is used to hold the drinks that have been ordered
        public static List<Drink> Orders = new List<Drink>();
        // This will later be persisted in Database


        // This list with mock data holds the list of drinks offered on the menu
        private static List<Drink> drinks
            = new List<Drink>()
            {
                new Drink {Name = "Covid Hot Dog", Description = "Will Give You A Virus", Price = 100},
                new Drink {Name = "White Claw", Description = "Millenials Love it", Price = 6},
                new Drink {Name = "Daniel's Special", Description = "Wouldn't you like to know", Price = 9},
                new Drink {Name = "Cindy's Special", Description = "Something about being great... blah blah blah", Price = 8}
            };


        // This method displays the list of drinks on the menu
        public ActionResult Index()  // If drinks List was instantiated here, it would be created each time method called.
        {

            return View(drinks);
        }


        // This method is invoked when a drink on the menu is ordered, adding it to the Orders List, then redisplaying menu
        public RedirectToRouteResult Order(Drink drink) // MVC takes values passed in here and makes new drink object
        {
            drink.Id = ++id;
            Orders.Add(drink);
            return RedirectToAction("Index");
        }
    }
}

