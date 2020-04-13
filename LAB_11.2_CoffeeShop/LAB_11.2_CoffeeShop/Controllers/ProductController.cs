using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using LAB_11._2_CoffeeShop.Models;

namespace LAB_11._2_CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("coffeeShopDB"));
        }

        public IActionResult Index()
        {
            ViewData["Products"] = dal.GetProductCategories(); 

            return View("ProductsIndex");
        }

        public IActionResult Cat(string cat)
        {
            ViewData["Title"] = cat;
            ViewData["Products"] = dal.GetProductsInCategory(cat);

            return View();
        }

        public IActionResult Detail(int id)
        {
            Product prod = dal.GetProductById(id);

            //check if anything was returned. If not...
            if (prod == null)
            {
                return View("NoSuchItem");
            }
            else
            {
                ViewData["Title"] = prod.Name;
                ViewData["Product"] = prod;

                return View();
            }
        }
    }
}