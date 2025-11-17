using NUnit.Framework;
using System;

[TestFixture]
public class LoanCalculatorTests
{
    private LoanCalculator _loanCalculator;

    [SetUp]
    public void Setup()
    {
        _loanCalculator = new LoanCalculator();
    }

    [TestCase(500000, 240, 5, "Returning", ExpectedResult = 3096.17)]
    [TestCase(750000, 360, 4, "New", ExpectedResult = 3487.26)]
    [TestCase(90000, 120, 6, "Returning", ExpectedResult = 985.07)]
    [TestCase(200000, 360, 2.5, "New", ExpectedResult = 764.49)]
    [TestCase(1000000, 240, 10, "Returning", ExpectedResult = 9179.5)]
    [TestCase(250000, 60, 8, "New", ExpectedResult = 5069.1)]
    public double CalculateMonthlyPayment_ValidInput_ReturnsExpectedResult(double loanAmount, int loanTermMonths, double annualInterestRate, string customerType)
    {
        // Arrange & Act
        return _loanCalculator.CalculateMonthlyPayment(loanAmount, loanTermMonths, annualInterestRate, customerType);
    }

    [TestCase(0, 12, 5, "New")]
    [TestCase(500000, 0, 5, "Returning")]
    [TestCase(500000, 12, -1, "Returning")]
    [TestCase(500000, 12, 5, "")]
    [TestCase(500000, 12, 5, "Invalid")]
    public void CalculateMonthlyPayment_InvalidInput_ThrowsArgumentException(double loanAmount, int loanTermMonths, double annualInterestRate, string customerType)
    {
        // Assert
        Assert.Throws<ArgumentException>(() => _loanCalculator.CalculateMonthlyPayment(loanAmount, loanTermMonths, annualInterestRate, customerType));
    }

    [Test]
    public void CalculateMonthlyPayment_MaxValues_DoesNotThrow()
    {
        // Arrange
        double loanAmount = 1_000_000;
        int loanTermMonths = 360;
        double annualInterestRate = 30;
        string customerType = "Returning";

        // Act & Assert
        Assert.DoesNotThrow(() => _loanCalculator.CalculateMonthlyPayment(loanAmount, loanTermMonths, annualInterestRate, customerType));
    }

    [Test]
    public void CalculateMonthlyPayment_MinValues_DoesNotThrow()
    {
        // Arrange
        double loanAmount = 1;
        int loanTermMonths = 6;
        double annualInterestRate = 0.01;
        string customerType = "New";

        // Act & Assert
        Assert.DoesNotThrow(() => _loanCalculator.CalculateMonthlyPayment(loanAmount, loanTermMonths, annualInterestRate, customerType));
    }
}
