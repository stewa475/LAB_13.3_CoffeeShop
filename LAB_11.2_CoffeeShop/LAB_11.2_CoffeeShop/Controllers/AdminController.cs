using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LAB_11._2_CoffeeShop.Models;
using Microsoft.Extensions.Configuration;

namespace LAB_11._2_CoffeeShop.Controllers
{
    public class AdminController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public AdminController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("coffeeShopDB"));
        }

        public IActionResult Index()
        {
            ViewData["Products"] = dal.GetProductsAll();

            return View("AdminIndex");
        }

        [HttpPost]
        public IActionResult Add(Product prod)
        {
            int result;
            //check the model for validity
            if (ModelState.IsValid)
            {
                result = dal.CreateProduct(prod);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("AddForm");
            }

            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully added";
            }
            else
            {
                TempData["UserMsg"] = "Item not added";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            //creating a new blank product
            Product prod = new Product();

            //putting the blank Product instance into the view as the model
            return View(prod);
        }

        //Deletes an item from te database using ID
        public IActionResult Delete(int id)
        {
            int result = dal.DeleteProductById(id);
            //check the result--0 means no matching id, 1 means 1 row affected

            //add data for the view before handing off
            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully deleted";
            }
            else
            {
                TempData["UserMsg"] = "Item for deletion not found";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }

        public IActionResult DeleteForm(int id)
        {
            Product prod = dal.GetProductById(id);

            ViewData["Title"] = prod.Name;
            ViewData["Product"] = prod;
 
            return View(prod);
        }

        //Different way of doing than AddForm/Add
        //two methods, same name, different annotations--one triggered by GET, the other POST
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product prod = dal.GetProductById(id);

            if (prod == null)
            {
                return View("NoSuchItem");
            }
            else
            {
                return View(prod);
            }
        }

        [HttpPost]
        public IActionResult Edit(Product prod)
        {
            int result;
            //check the model for validity
            if (ModelState.IsValid)
            {
                result = dal.UpdateProductById(prod);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View(prod);
            }

            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully updated";
            }
            else
            {
                TempData["UserMsg"] = "Item not updated";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }
    }
}