[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnSum_WhenCalledWithTwoIntegers()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.AreEqual(8, result);
    }

    [TestCase(5, 3, 8)]
    [TestCase(-5, -3, -8)]
    [TestCase(-5, 3, -2)]
    public void Add_ShouldReturnSum_WhenCalledWithTwoIntegers(int a, int b, int expected)
    {
        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Divide_ShouldThrowArgumentException_WhenDividingByZero()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Divide(10, 0));
    }

    [Test]
    public void Add_ShouldHandleLargeNumbers()
    {
        int result = _calculator.Add(int.MaxValue, 0);
        Assert.AreEqual(int.MaxValue, result);
    }

    [Test]
    public void Substract_ShouldHandleLargeNumbers()
    {
        int result = _calculator.Subtract(-1, int.MaxValue);
        Assert.AreEqual(int.MinValue, result);
    }

}
