namespace ProductDiscountCalculatorTest
{
    [TestFixture]
    public class ProductDiscountCalculatorTests
    {
        private ProductDiscountCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new ProductDiscountCalculator();
        }

        [TestCase(1200, "Electronics", 2, "DISCOUNT10", ExpectedResult = 1920)]
        [TestCase(1000, "Clothing", 5, "DISCOUNT20", ExpectedResult = 3750)]
        [TestCase(450, "Furniture", 1, "DISCOUNT50", ExpectedResult = 270)]
        [TestCase(700, "Electronics", 3, "", ExpectedResult = 1890)]
        [TestCase(300, "Clothing", 4, "", ExpectedResult = 1140)]
        [TestCase(2000, "Furniture", 2, "DISCOUNT25", ExpectedResult = 3000)]
        public double CalculateDiscountedPrice_ValidInputs_ReturnsExpectedResult(
            double originalPrice, string category, int quantity, string discountCode)
        {
            // Arrange is already set up

            // Act
            var result = _calculator.CalculateDiscountedPrice(originalPrice, category, quantity, discountCode);

            // Assert
            return result;
        }

        [Test]
        public void CalculateDiscountedPrice_InvalidPrice_ThrowsArgumentException()
        {
            // Arrange, Act, Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateDiscountedPrice(-1, "Electronics", 2, "DISCOUNT10"));
        }

        [Test]
        public void CalculateDiscountedPrice_NullCategory_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculateDiscountedPrice(100, null, 2, "DISCOUNT10"));
        }

        [Test]
        public void CalculateDiscountedPrice_EmptyCategory_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculateDiscountedPrice(100, "", 2, "DISCOUNT10"));
        }

        [Test]
        public void CalculateDiscountedPrice_InvalidQuantity_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculateDiscountedPrice(100, "Clothing", 0, "DISCOUNT10"));
        }

        [Test]
        public void CalculateDiscountedPrice_LongDiscountCode_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculateDiscountedPrice(100, "Clothing", 2, "LONGCODE123"));
        }

        [Test]
        public void CalculateDiscountedPrice_ExtremeValues_NoException()
        {
            Assert.DoesNotThrow(() =>
                _calculator.CalculateDiscountedPrice(double.MaxValue, "Electronics", int.MaxValue, "DISCOUNT40"));
        }
    }

}