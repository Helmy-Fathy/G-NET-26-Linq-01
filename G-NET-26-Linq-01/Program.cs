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

        }
    }
}
