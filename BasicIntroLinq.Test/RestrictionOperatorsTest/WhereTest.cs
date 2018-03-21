using System.Collections.Generic;
using System.Linq;
using BasicIntroLinq.RestrictionOperators;
using BasicIntroLinq.RestrictionOperators.Data;
using NUnit.Framework;

namespace BasicIntroLinq.Test.RestrictionOperators
{
    [TestFixture]
    public class WhereTest
    {
        private EFProducts _products = new EFProducts();
        private Where _where = new Where();
        [Test]
        public void WhereSimple1_NumbersBelow6_ReturnIntArray()
        {
            var resultArray = new int[] { 1, 2, 3, 4, 5 };
            var numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Assert.AreEqual(resultArray, _where.WhereSimple1(6, numArray));
        }

        [Test]
        public void WhereSimple2_OutOfStock_ReturnProducts()
        {
            // //TODO: implement moq
            // List<Product> products =
            //         new List<Product> {
            //         new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.3500M, UnitsInStock = 0 },
            //         new Product { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.0000M, UnitsInStock = 0 },
            //         new Product { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry", UnitPrice = 123.7900M, UnitsInStock = 0 },
            //         new Product { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products", UnitPrice = 12.5000M, UnitsInStock = 0 },
            //         new Product { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.8000M, UnitsInStock = 0 }
            // };            

            // CollectionAssert.AreEqual(products, products);//_where.WhereSimple2(_products.Get));
        }

        [Test]
        public void WhereSimple2_InStocksAndOver3_ReturnProducts()
        {
            // TODO:implement moq           

        }
        [Test]
        public void WhereIndexed_ShorterThenThierValue_ReturnDigits()
        {
            var resultArray = new string[] { "five", "six", "seven", "eight", "nine" };
            var numArray = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Assert.AreEqual(resultArray, _where.WhereIndexted(numArray));

        }


    }
}