using System.Collections.Generic;
using System.Linq;
using BasicIntroLinq.Models;
using BasicIntroLinq.Models.ViewModels;

namespace BasicIntroLinq.ProjectionOperators
{
    public class Select
    {
        // This sample uses select to produce a sequence 
        //of ints one higher than those in an existing array of ints.
        public int[] SelectSimple1(int[] numbers)
        {
            //-- Linq Query operators -- 
            var nunsPlussOne =
                (from number in numbers
                 select number + 1).ToArray();

            // --Linq Extension methods
            var nunsPlussOne2 = numbers.Select(number => number + 1);

            return nunsPlussOne;
        }

        // this sample uses select to return a
        // sequence of just the names of a list of products
        public List<Product> SelectSimple2(List<Product> products)
        {
            //-- Linq Query operators -- 
            var productNames =
                (from product in products
                 select product.ProductName).ToList();

            //-- Linq Extension methods
            var productNames2 = products.Select(product => product.ProductName);

            return products;
        }

        // This sample uses select to produce a seqiemce of 
        // string representing the text version of a sequence of ints
        public string[] SelectTransformation(int[] numbers, string[] strings)
        {
            // -- Linq Query operators -- 
            var textNums =
            (from number in numbers
             select strings[number]).ToArray();

            // -- Linq Extension methods --
            var textNumbs2 = numbers.Select(number => strings[number])
                                    .ToArray();

            return textNums;
        }

        // This sample uses select to produce a sequence of the uppercase and 
        // lowercase version of each word in the original array
        public List<LowerAndUpperViewModel> SelectAnonymousType1(string[] words)
        {
            // -- Linq Query operators --
            var upperLowerWords =
                from word in words
                select new LowerAndUpperViewModel { Upper = word.ToUpper(), Lower = word.ToLower() };

            // -- Linq Extension methods -- 
            var upperLowerWords2 =
            words.Select(word => new LowerAndUpperViewModel { Upper = word.ToUpper(), Lower = word.ToLower() });
            return upperLowerWords.ToList();
        }
        // This sample uses select to produce a sequence containing text representation¨
        // of digits and whether their length is even or odd.
        public List<OddEvenViewModel> SelectAnonymousType2(int[] numbers, string[] words)
        {
            // -- Linq Query operators --
            var digitOddEvens =
                from number in numbers
                select new OddEvenViewModel { Digit = words[number], Even = (number % 2 == 0) };

            // -- Linq Extension methods -- 
            var digitOddEvens2 =
            numbers.Select(number => new OddEvenViewModel { Digit = words[number], Even = (number % 2 == 0) });
            return digitOddEvens.ToList();
        }

        // This sample uses select to produce a sequence containing some properties of Products, 
        // including UnitPrice which is renamed to Price in the resulting type
        public List<ProductViewModel> SelectAnonymousType3(List<Product> products)
        {

            // -- Linq Query operators --
            var productInto =
                from product in products
                select new ProductViewModel { ProductName = product.ProductName, Category = product.Category, Price = product.UnitPrice };

            // -- Linq Extension methods --
            var productInto2 =
                products.Select(product =>
                new ProductViewModel { ProductName = product.ProductName, Category = product.Category, Price = product.UnitPrice });

            return productInto.ToList();

        }

        // This sample uses an indexed Select clause to determine if the value
        // of the ints in an array match  their position in the array.
        public List<SelectIndexViewModel> SelectIndexed(int[] numbers)
        {
            // -- Linq Query operators -- 
            var numsInPlace =
                from number in numbers.Select((number, index) => new { Number = number, InPlace = (number == index) })
                group number by new SelectIndexViewModel { Number = number.Number, InPlace = number.InPlace };

            // -- Linq Extension method --
            var numsInPlace2 =
            numbers.Select((number, index) => new SelectIndexViewModel { Number = number, InPlace = (number == index) });

            return numsInPlace2.ToList();
        }

        // This sample combines select and where to make simple
        // query that retursn the text from each digit less than 5
        public string[] SelectFiltered(int[] numbers, string[] words)
        {
            // -- Linq Query operations --
            var lowNum =
            (from number in numbers
             where number < 5
             select words[number]).ToArray();

            // -- Linq Extention method --
            var lowNum2 =
                numbers.Where(number => number < 5)
                       .Select(number => words[number]).ToArray();

            return lowNum;
        }

        // This sample uses a compund from clause to make a query that returns
        // all pairs of numbers from both arrays such that the numbers
        // from numbersA is less then the numbers from numbersB
        public IEnumerable<NumberAAndBViewModel> SelectManyCompoundFrom1(int[] numbersA, int[] numbersB)
        {
            // -- Linq Query operations --
            var pairs =
                from numberA in numbersA
                from numberB in numbersB
                where numberA < numberB
                select new NumberAAndBViewModel {NumberA = numberA, NumberB = numberB};

            // -- Linq Extension methods
            var pairs2 =
            numbersA.Where((numberA, index) => numberA < numbersB[index])
                    .Select((numberA, index) => new NumberAAndBViewModel {NumberA = numberA , NumberB = numbersB[index]});
            // SelectMany
            var pairs3 =
            numbersA.Where((numberA, index) => numberA < numbersB[index])
                    .SelectMany(numA=> numbersB, (a,b) => new NumberAAndBViewModel {NumberA = a, NumberB = b} );       
        
            return pairs;
        }

        // This sample uses a compound from clause to select all orders
        // where the order total is less than 500.00
        public IEnumerable<CustomerAndOrderViewModel> SelectManyCompoundFrom2(List<Customer> customers)
        {
            // -- Linq Query operation
            var orders =
            from customer in customers
            from order in customer.Orders
            where order.Total < 5000.00M
            select new CustomerAndOrderViewModel 
            {CustomerID = customer.CustomerID, 
             OrderID = order.OrderID, 
             Total = order.Total};

            // -- Linq Extension method
            // var orders2 =
            // customers
            //     .Where(customer => customer.Orders.Where(o=>o.Total>500))            
            //     .SelectMany(customer => customer.Orders, (c,o) => 
            //         new CustomerAndOrderViewModel
            //         {CustomerID = c.CustomerID, 
            //          OrderID = o.OrderID, 
            //          Total = o.Total});

            return orders;
        }

    }
}