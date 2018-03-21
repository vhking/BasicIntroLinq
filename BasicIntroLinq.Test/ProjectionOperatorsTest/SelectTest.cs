using BasicIntroLinq.ProjectionOperators;
using NUnit.Framework;

namespace BasicIntroLinq.Test.ProjectionOperatorsTest
{
    [TestFixture]
    public class SelectTest
    {
        private Select _select = new Select();
        [Test]
        public void SelectSimple1_OneHigher_ReturnArray()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int[] result = { 6, 5, 2, 4, 10, 9, 7, 8, 3, 1 };

            Assert.AreEqual(result, _select.SelectSimple1(numbers));
        }

        [Test]
        public void SelectSimple2_JustNames_ReturnProductNames()
        {
            //TODO: implement moq
        }

        [Test]
        public void SelectTransformation_RearrangeToNumbers_ReturnArray()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] result = { "five", "four", "one", "three", "nine", "eight", "six", "seven", "two", "zero" };
            Assert.AreEqual(result , _select.SelectTransformation(numbers, strings));
        }
    }
}