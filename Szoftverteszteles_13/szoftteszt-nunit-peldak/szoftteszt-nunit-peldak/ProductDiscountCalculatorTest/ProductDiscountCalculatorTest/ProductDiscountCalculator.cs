using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountCalculatorTest
{
    public class ProductDiscountCalculator
    {
        public double CalculateDiscountedPrice(double originalPrice, string category, int quantity, string discountCode)
        {
            // Input validation
            if (originalPrice <= 0)
                throw new ArgumentException("Original price must be positive.");
            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("Category cannot be null or empty.");
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive.");
            if (discountCode != null && discountCode.Length > 10)
                throw new ArgumentException("Discount code cannot exceed 8 characters.");

            // Calculate discounts
            double discount = 0;

            if (category == "Electronics" && originalPrice > 500)
                discount += 10; // 10% for Electronics over 500

            if (category == "Clothing" && quantity >= 3)
                discount += 5; // 5% for Clothing with quantity >= 3

            if (!string.IsNullOrEmpty(discountCode) && discountCode.StartsWith("DISCOUNT"))
            {
                if (int.TryParse(discountCode.Substring(8), out int discountValue))
                {
                    discount += discountValue; // Add discount based on the code
                }
            }

            // Cap the discount at 40%
            discount = Math.Min(discount, 40);

            // Apply discounts
            double discountedPricePerItem = originalPrice * (1 - discount / 100);
            return discountedPricePerItem * quantity;
        }
    }

}
