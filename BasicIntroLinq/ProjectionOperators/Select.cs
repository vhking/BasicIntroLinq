using System.Linq;

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
        //sequence of just the names of a list of products
        
    }
}