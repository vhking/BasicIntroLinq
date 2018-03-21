using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using BasicIntroLinq.RestrictionOperators.Models;

namespace BasicIntroLinq.RestrictionOperators
{
    public class Where
    {

        // This sample uses whereto find all elements of an 
        // array less then a spesific value.        
        public int[] WhereSimple1(int value, int[] numArray)
        {
            // selects the numbers that are lower than the
            // value of the 'value' variable.
            // and stores them in a IEnumerable collection
            //-- Linq Query operators --
            var lowNums =
                from number in numArray
                where number < value
                select number;
            // -- Linq Extension methods --
            var lowNums2 = numArray
                            .Where(number => number < value)
                            .Select(number => number);

            // return result as a array
            return lowNums2.ToArray();
        }

        //This sample uses where to find all products that are out of stock.
        public List<Product> WhereSimple2(List<Product> products)
        {
            //-- Linq Query operators
            var soldOutProducts =
               (from product in products
                where product.UnitsInStock == 0
                select product).ToList();


            //-- Linq Extension methods --
            var soldOutProducts2 =
                products.Where(product => product.UnitsInStock == 0)
                        .Select(product => product).ToList();

            return soldOutProducts;
        }

        //This sample uses where to find all products that are in stock and cost more than 3.00 per unit.
        public List<Product> WhereSimple3(List<Product> products)
        {
            //-- Linq Query operators
            var expensiveInStockProducts =
               (from product in products
                where product.UnitsInStock > 0 && product.UnitPrice > 3.00M
                select product).ToList();
            //-- Linq Extension methods --
            var expensiveInStockProducts2 = products.Where(product => product.UnitsInStock > 0)
                                                    .Where(product => product.UnitPrice > 3.00M)
                                                    .Select(product => product).ToList();

            return expensiveInStockProducts;
        }

        // This sample uses where to find all customers in Washington and 
        // then uses the resulting sequence to drill down into their orders.
        public List<Customer> WhereDrillDown(List<Customer> customers)
        {
            //-- Linq Query operators -- 
            var waCustomers =
                (from customer in customers
                 where customer.Region == "WA"
                 select customer).ToList();

            //-- Linq Extension methods --
            var waCustomers2 = customers.Where(customer => customer.Region == "WA")
                                        .Select(customer => customer).ToList();

            return waCustomers;
        }
        // This sample demonstrates an indexed Where clause that returns digits 
        // whose name is shorter than their value.
        public string[] WhereIndexted(string[] digits)
        {
            //-- Linq Query operators -- 
            // Does not seem to be possible by only using Linq Query operators
            var shortDigits =
                from digit in digits.Select((value, index) => new { value, index })
                 where digit.value.Length < digit.index
                 select digit;

            //-- Linq Extension methods --
            var shortDigits2 = digits.Where((digit, index) => digit.Length < index).ToArray();

            return shortDigits2;
        }



    }
}