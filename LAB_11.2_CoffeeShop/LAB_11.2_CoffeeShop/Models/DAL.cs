﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace LAB_11._2_CoffeeShop.Models
{
    public class DAL
    {
        SqlConnection connection;

        public DAL(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            //TODO: close the connection!!!
        }
        //TODO: Use try/catches around these!

        public IEnumerable<Product> GetProductCategories()
        {
            string queryString = "SELECT DISTINCT Category FROM Products";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }

        public IEnumerable<Product> GetProductsAll()
        {
            string queryString = "SELECT * FROM Products ORDER BY Category, Name";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }
        public Product GetProductById(int id)
        {
            string queryString = "SELECT * FROM Products WHERE Id = @val";
            Product prod = connection.QueryFirstOrDefault<Product>(queryString, new { val = id });

            return prod;
        }

        public IEnumerable<Product> GetProductsInCategory(string cat)
        {
            string queryString = "SELECT * FROM Products WHERE Category = @val";
            IEnumerable<Product> Products = connection.Query<Product>(queryString, new { val = cat });

            return Products;
        }

        public int CreateProduct(Product prod)
        {
            string addString = "INSERT INTO Products (Name, Category, Description, Price) ";
            addString += "VALUES (@Name, @Category, @Description, @Price)";

            return connection.Execute(addString, prod);
        }

        public int DeleteProductById(int id)
        {
            string deleteString = "DELETE FROM Products WHERE Id = @val";
            return connection.Execute(deleteString, new { val = id });
        }

        public int UpdateProductById(Product prod)
        {
            string editString = "UPDATE Products SET Name = @Name, Description = @Description, ";
            editString += "Category = @Category, Price = @Price WHERE Id = @Id";
            return connection.Execute(editString, prod);
        }
    }
}
