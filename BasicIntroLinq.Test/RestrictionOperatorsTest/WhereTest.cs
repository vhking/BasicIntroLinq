using BasicIntroLinq.RestrictionOperators;
using NUnit.Framework;

namespace BasicIntroLinq.Test.RestrictionOperators
{
    [TestFixture]
    public class WhereTest
    {
        private Where _where = new Where();
        [Test]
        public void WhereSimple1_NumbersBelow6_ReturnIntArray()
        {
            var resultArray =new int[]{1,2,3,4,5};
            var numArray = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            Assert.AreEqual(resultArray, _where.WhereSimple1(6, numArray));
        }

        public void WhereSimple2_OutOfStock_ReturnProducts()
        {
            
        }
    }
}