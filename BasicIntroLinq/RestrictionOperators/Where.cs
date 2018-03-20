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

        public List<Product> WhereSimple2(List<Product> products)
        {
            var soldOutProducts =
               (from product in products
                where product.UnitsInStock == 0
                select product).ToList();

            var soldOutProducts2 = 
                products.Where(product => product.UnitsInStock == 0)
                        .Select(product => product);

            return soldOutProducts;
        }
    }
}