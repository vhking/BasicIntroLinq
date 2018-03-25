using System.Collections.Generic;
using BasicIntroLinq.Models.ViewModels;
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
            Assert.AreEqual(result, _select.SelectTransformation(numbers, strings));
        }

        [Test]
        public void SelectAnonymousType1_ToLowerAndUpper_ReturnList()
        {
            //TODO: moq?
            // string[] strings = { "aPPLE", "BlUeBeRrY", "cHeRry"};
            // List<LowerAndUpperViewModel> result = new List<LowerAndUpperViewModel>
            // { 
            //     new LowerAndUpperViewModel {Upper = "APPLE", Lower = "apple"},
            //     new LowerAndUpperViewModel {Upper = "BLUEBERRY", Lower = "blueberry"},
            //     new LowerAndUpperViewModel {Upper = "CHERRY", Lower = "cherry"}

            // };

            // Assert.AreEqual(result , _select.SelectAnonymousType1(strings));
        }

        [Test]
        public void SelectAnonymousType2_FindEvenAndOdd_ReturnList()
        {
            //TODO: moq?
            // string[] strings = { "aPPLE", "BlUeBeRrY", "cHeRry"};
            // List<LowerAndUpperViewModel> result = new List<LowerAndUpperViewModel>
            // { 
            //     new LowerAndUpperViewModel {Upper = "APPLE", Lower = "apple"},
            //     new LowerAndUpperViewModel {Upper = "BLUEBERRY", Lower = "blueberry"},
            //     new LowerAndUpperViewModel {Upper = "CHERRY", Lower = "cherry"}

            // };

            // Assert.AreEqual(result , _select.SelectAnonymousType1(strings));
        }

        [Test]
        public void SelectAnonymousType3_Rename_ReturnProducts()
        {
            //TODO: moq?

        }

        [Test]
        public void SelectIndexed_NumInPosition_ReturnList()
        {
            //TODO: moq?

        }

        [Test]
        public void SelectFiltered_LessThen5_ReturnArrey()
        {

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] result = { "four", "one", "three", "two", "zero" };

            Assert.AreEqual(result, _select.SelectFiltered(numbers, strings));

        }

        [Test]
        public void SelectManyCompoundFrom1_ALessThenB_ReturnList()
        {

        }

        [Test]
        public void SelectManyCompoundFrom2_OrdersLessThen500_ReturnList()
        {

        }

        [Test]
        public void SelectManyCompoundFrom3_Orders1998OrLater_ReturnList()
        {

        }
        [Test]
        public void SelectManyFromAssignment_OrdersGreaterThen2000_ReturnList()
        {

        }
        [Test]
        public void SelectManyMultipleFrom_Orders1997OrLaterWA_ReturnList()
        {

        }
        [Test]
        public void SelectManyIndexted_ByOrder_ReturnArray()
        {

        }

    }
}