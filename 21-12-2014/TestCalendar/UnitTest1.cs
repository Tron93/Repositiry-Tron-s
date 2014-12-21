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
        private readonly IEnumerable<int> ListOfDayNonLeap = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private readonly IEnumerable<int> ListOfDayLeap = new List<int> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        [TestMethod]
        public void Test_GetMonthAndDay_NonLeap()
        {
            // Arrange
            CalculateDate calc = new CalculateDate(new WriterFactory().CreateWriter());

            // Act
            DayOfMonth febOne = calc.GetMonthAndDay(32, ListOfDayNonLeap);

            // Assert
            Assert.AreEqual<Month>(Month.February, febOne.Mon);
            Assert.AreEqual<int>(1, febOne.Day);
        }

        [TestMethod]
        public void Test_GetMonthAndDay_Leap()
        {
            // Arrange
            CalculateDate calc = new CalculateDate(new WriterFactory().CreateWriter());

            // Act
            DayOfMonth julFour = calc.GetMonthAndDay(186, ListOfDayLeap);

            // Assert
            Assert.AreEqual<Month>(Month.July, julFour.Mon);
            Assert.AreEqual<int>(4, julFour.Day);
        }

        [TestMethod]
        public void Test_IsLeapYear_NonLeapYear()
        {
            IsLeapYearTestHelper(1999, false);
        }

        [TestMethod]
        public void Test_IsLeapYear_LeapYear()
        {
            IsLeapYearTestHelper(2000, true);
        }

        private void IsLeapYearTestHelper(int yearToCheck, bool expected)
        {
            // Arrange
            CalculateDate calc = new CalculateDate(new WriterFactory().CreateWriter());

            // Act
            bool actual = calc.IsLeapYear(yearToCheck);

            // Assert
            Assert.AreEqual<bool>(expected, actual);
        }
    }
}