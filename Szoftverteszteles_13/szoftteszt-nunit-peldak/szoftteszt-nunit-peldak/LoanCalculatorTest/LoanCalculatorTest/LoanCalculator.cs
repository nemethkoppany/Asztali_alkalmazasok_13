using System;

public class LoanCalculator
{
    public double CalculateMonthlyPayment(double loanAmount, int loanTermMonths, double annualInterestRate, string customerType)
    {
        // Input validation
        if (loanAmount <= 0 || loanAmount > 1_000_000)
            throw new ArgumentException("Loan amount must be positive and no greater than 1,000,000.");

        if (loanTermMonths < 6 || loanTermMonths > 360)
            throw new ArgumentException("Loan term must be between 6 and 360 months.");

        if (annualInterestRate <= 0 || annualInterestRate > 30)
            throw new ArgumentException("Annual interest rate must be positive and no greater than 30.");

        if (string.IsNullOrEmpty(customerType) || (customerType != "New" && customerType != "Returning"))
            throw new ArgumentException("Customer type must be 'New' or 'Returning'.");

        // Monthly interest rate calculation (adjusted for any discounts)
        double discount = 0;
        if (customerType == "Returning") discount += 0.5;
        if (loanTermMonths > 180) discount += 0.25;

        discount = Math.Min(discount, 1.0);  // Maximum discount of 1%

        // Apply the discount to annual interest rate and calculate monthly rate
        double adjustedAnnualRate = annualInterestRate - discount;
        double monthlyRate = (adjustedAnnualRate / 12) / 100;

        // Calculate the monthly payment based on the adjusted interest rate
        double monthlyPayment = (loanAmount * monthlyRate) /
            (1 - Math.Pow(1 + monthlyRate, -loanTermMonths));

        // Apply additional fees based on loan amount
        if (loanAmount > 500_000)
            monthlyPayment += 5000.0 / loanTermMonths;
        else if (loanAmount < 100_000)
            monthlyPayment += 1000.0 / loanTermMonths;

        return Math.Round(monthlyPayment, 2);
    }
}
