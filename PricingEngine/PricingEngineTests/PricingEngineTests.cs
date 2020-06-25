using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingBasics;

namespace EngineTests
{
    [TestClass]
    public class PricingEngineTests
    {
        [TestMethod]
        public void CalculateUnitPrice_BelowMinPrice()
        {
            // arrange

            // act

            // assert

        }

        [TestMethod]
        public void CalculateUnitPrice_MinPrice()
        {
            // arrange

            // act

            // assert

        }

        [TestMethod]
        public void CalculateUnitPrice_BelowMinQty()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyLower()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyUpper()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CalculateUnitPrice_QtyGT20()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinPrice()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinTotal()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold

            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold

            // arrange

            // act

            // assert
        }
    }
}
