namespace OrderProcessorTest
{
    [TestFixture]
    public class OrderProcessorTests
    {
        OrderProcessor orderProcessor;

        [SetUp]
        public void Setup()
        {
            orderProcessor = new OrderProcessor();
        }

        // Arrange
        [TestCase(1200, 100, "PROMO10", true, 840)]
        [TestCase(600, 50, "PROMO25", false, 890)]
        [TestCase(300, 10, "PROMO10", true, 355)]
        [TestCase(2000, 1, "", false, 1700)]
        [TestCase(400, 30, "", false, 700)]
        [TestCase(1500, 30, "", false, 1275)]
        [TestCase(2000, 20, "PROMO40", true, 1000)]
        public void CalculateOrderPrice_ShouldReturnTheCorrectValue(double orderPrice, int shippingDistance,
            string promoCode, bool isLoyalCustomer, double expected)
        {
            // Act
            double result = orderProcessor.CalculateOrderPrice(orderPrice, shippingDistance, promoCode, 
                isLoyalCustomer);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void CalculateOrderPrice_ShouldThrowArgumentException_WhenOrderPriceIsNegative()
        {
            // Arrange
            double orderPrice = -1;
            int shippingDistance = 50;
            string promoCode = "PROMO10";
            bool isLoyalCustomer = true;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => orderProcessor.CalculateOrderPrice(orderPrice, shippingDistance, promoCode, isLoyalCustomer));
        }

        [Test]
        public void CalculateOrderPrice_ShouldThrowArgumentException_WhenShippingDistanceIsNegative()
        {
            // Arrange
            double orderPrice = 100;
            int shippingDistance = -5;
            string promoCode = "PROMO10";
            bool isLoyalCustomer = false;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => orderProcessor.CalculateOrderPrice(orderPrice, shippingDistance, promoCode, isLoyalCustomer));
        }

        [Test]
        public void CalculateOrderPrice_ShouldThrowArgumentException_WhenPromoCodeTooLong()
        {
            // Arrange
            double orderPrice = 100;
            int shippingDistance = 10;
            string promoCode = "PROMOEXCEED10";
            bool isLoyalCustomer = false;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => orderProcessor.CalculateOrderPrice(orderPrice, shippingDistance, promoCode, isLoyalCustomer));
        }
    }
}