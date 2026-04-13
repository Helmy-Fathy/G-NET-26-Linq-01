using LINQ.Models;
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
            //5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category. 
            var result = ProductList.Where( p => p.UnitsInStock > 0 && p.Category == "Condiments");
            #endregion
        }
    }
}
