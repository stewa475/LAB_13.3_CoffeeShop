using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LAB_11._2_CoffeeShop.Models
{
    public class Product
    {

        private int id;
        private string name;
        private double price;
        private string description;
        private string category;
        private static string[] categoryList = { "Categories", "Americanos", "Brewed Coffees", "Cappuccinos", "Espresso Shots", "Flat Whites", "Lattes", "Macchiatos" };

        public int Id { get => id; set => id = value; }

        [DisplayName("Name")]
        [Required]
        [MinLength(2)]
        public string Name { get => name; set => name = value; }

        [DisplayName("Price")]
        [Required]
        public double Price { get => price; set => price = value; }

        [DisplayName("Description")]
        [Required]
        [MinLength(2)]
        public string Description { get => description; set => description = value; }

        [DisplayName("Category")]
        [Required]
        public string Category { get => category; set => category = value; }

        public static string[] CategoryList { get => categoryList; set => categoryList = value; }
    }
}
