using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace TestCalendar
{
    [TestClass]
    public class YaerAndDateTest
    {
        [TestMethod]
        public void TestYaer
        {
            DayOfMonth febOne = CalcDate.GetMonthAndDay(32);
            DayOfMonth marOne = CalcDate.GetMonthAndDay(60);
            DayOfMonth aprOne = CalcDate.GetMonthAndDay(91);
            DayOfMonth julFive = CalcDate.GetMonthAndDay(186);
            DayOfMonth octThirtyOne = CalcDate.GetMonthAndDay(304);
            DayOfMonth novFive = CalcDate.GetMonthAndDay(309);
            DayOfMonth novTwentyThree = CalcDate.GetMonthAndDay(327);
            DayOfMonth decTwentyFive = CalcDate.GetMonthAndDay(359);

            Assert.AreEqual<Month>(Month.February, febOne.Mon);
            Assert.AreEqual<int>(1, febOne.Day);
            Assert.AreEqual<Month>(Month.March, marOne.Mon);
            Assert.AreEqual<int>(1, marOne.Day);
            Assert.AreEqual<Month>(Month.April, aprOne.Mon);
            Assert.AreEqual<int>(1, aprOne.Day);
            Assert.AreEqual<Month>(Month.July, julFive.Mon);
            Assert.AreEqual<int>(5, julFive.Day);
            Assert.AreEqual<Month>(Month.October, octThirtyOne.Mon);
            Assert.AreEqual<int>(31, octThirtyOne.Day);
            Assert.AreEqual<Month>(Month.November, novFive.Mon);
            Assert.AreEqual<int>(5, novFive.Day);
            Assert.AreEqual<Month>(Month.November, novTwentyThree.Mon);
            Assert.AreEqual<int>(23, novTwentyThree.Day);
            Assert.AreEqual<Month>(Month.December, decTwentyFive.Mon);
        }
    }
}
