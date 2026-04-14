using LINQ.Helpers;
using LINQ.Models;
using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;
using static LINQ.DataSources.Source;

namespace G_NET_26_Linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Get all products from the "Seafood" category
            ////1. Get all products from the "Seafood" category. Print each product's name and price.
            //var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");
            //foreach (var product in seafoodProducts)
            //{
            //    Console.WriteLine($"Product's name: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            #endregion

            #region 2.Get a list of only the product names from ProductList
            ////2.Get a list of only the product names from ProductList.Print each name.
            //var productNames = ProductList.Select(p => p.ProductName).ToList();
            //foreach (var pName in productNames)
            //{
            //    Console.WriteLine(pName);
            //}
            #endregion

            #region 3.Sort all products by UnitPrice(ascending)
            ////3.Sort all products by UnitPrice(ascending). Print each product's name and price.
            //var sortedProds = ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var product in sortedProds)
            //{
            //    Console.WriteLine($"Product's name: {product.ProductName}, Price: {product.UnitPrice}");
            //}

            #endregion

            #region 4. Get all products where UnitPrice is between 10 and 30
            ////4. Get all products where UnitPrice is between 10 and 30 
            //var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            #endregion

            #region 5.Get all Condiments products that are in stock 
            ////5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category. 
            //var result = ProductList.Where( p => p.UnitsInStock > 0 && p.Category == "Condiments");
            #endregion

            #region 6. Create a new anonymous type with three properties
            ////6. Create a new anonymous type with three properties:
            ////● Name → the product name
            ////● Price → the unit price
            ////● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            ////● Print the result. 
            //var result = ProductList.Select(p => new {Name = p.ProductName, Price = p.UnitPrice, StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock" });
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 7. Print each product's name along with its position (1-based)in the list
            ////7. Print each product's name along with its position (1-based)in the list. Expected format: 1.Chai, 2.Chang, etc. 
            //var result = ProductList.Select((p, i) => $"{i + 1} . {p.ProductName}");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8. Sort ProductList by Category ascending
            ////8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            #endregion

            #region 9. Get all products from the "Beverages" category, sorted by UnitsInStock descending
            ////9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            //var result = ProductList.Where(p => p.Category == "Beverages").OrderBy(p => p.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} : {item.UnitsInStock}");
            //}
            #endregion

            #region 10. Using QUERY SYNTAX with a compound from clause
            ////10. Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate >= new DateTime(1997, 1, 1)
            //             select new
            //             {
            //                 c.CustomerID,
            //                 o.OrderDate
            //             };
            #endregion

            #region 11. Show position number alongside ProductName
            ////11. Show position number alongside ProductName
            //var result = ProductList.Select((p, i) => $"{i}. {p.ProductName}");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 12. Sort first by-word length and then by a case -insensitive
            ////12. Sort first by-word length and then by a case -insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word , new StringCaseInsensitiveComparer());
            #endregion
        }
    }
}
