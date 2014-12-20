using System;
using _13_12_2014;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _13_12_2014_Tests
{
    [TestClass]
    public class CalcDateTest
    {
        [TestMethod]
        public void TestRegularYear()
        {
            MonthDay febOne = CalcDate.GetMonthAndDay(32);
            MonthDay marOne = CalcDate.GetMonthAndDay(60);
            MonthDay aprOne = CalcDate.GetMonthAndDay(91);
            MonthDay julFive = CalcDate.GetMonthAndDay(186);
            MonthDay octThirtyOne = CalcDate.GetMonthAndDay(304);
            MonthDay novFive = CalcDate.GetMonthAndDay(309);
            MonthDay novTwentyThree = CalcDate.GetMonthAndDay(327);
            MonthDay decTwentyFive = CalcDate.GetMonthAndDay(359);

            Assert.AreEqual<Month>(Month.Feb, febOne.Mon);
            Assert.AreEqual<int>(1, febOne.Day);
        }
    }
}
