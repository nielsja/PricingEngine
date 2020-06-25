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
            bool holiday = false;
            int quantity = 20;
            decimal retailPrice = 1.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);
            
            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(1.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_MinPrice()
        {
            // arrange
            bool holiday = false;
            int quantity = 20;
            decimal retailPrice = 1.01m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(0.909m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_BelowMinQty()
        {
            // arrange
            bool holiday = false;
            int quantity = 10;
            decimal retailPrice = 10.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(10.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyLower()
        {
            // arrange
            bool holiday = false;
            int quantity = 11;
            decimal retailPrice = 10.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(9.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyUpper()
        {
            // arrange
            bool holiday = false;
            int quantity = 20;
            decimal retailPrice = 10.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(9.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_QtyGT20()
        {
            // arrange
            bool holiday = false;
            int quantity = 21;
            decimal retailPrice = 10.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(8.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinPrice()
        {
            // arrange
            bool holiday = true;
            int quantity = 1500;
            decimal retailPrice = 1.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(1.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinTotal()
        {
            // arrange
            bool holiday = true;
            int quantity = 10;
            decimal retailPrice = 100.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(100.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinQty()
        {
            // arrange
            bool holiday = true;
            int quantity = 10;
            decimal retailPrice = 150.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(135.00m, unitPrice);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayMinQty()
        {
            // arrange
            bool holiday = true;
            int quantity = 11;
            decimal retailPrice = 150.00m;
            PricingEngine pricingEngine = new PricingEngine(holiday);

            // act
            decimal unitPrice = pricingEngine.CalculateUnitPrice(quantity, retailPrice);

            // assert
            Assert.AreEqual(120.00m, unitPrice);
        }
    }
}
