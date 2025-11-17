using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessorTest
{
    internal class OrderProcessor
    {
        public const string PROMO_PREFIX = "PROMO"; 

        public double CalculateOrderPrice(double orderPrice, int shippingDistance, 
            string promoCode, bool isLoyalCustomer)
        {
            if (orderPrice < 1) throw new ArgumentException("Invalid order price: " + orderPrice);
            if (shippingDistance < 1) throw new ArgumentException("Invalid shipping distance: " + shippingDistance);
            if (promoCode != null && promoCode.Length > 10) {
                throw new ArgumentException("Invalid promocode: " + promoCode);
            }

            double discount = 0;

            if(orderPrice > 1000)
            {
                discount += 0.15;
            }
            else if(orderPrice > 500)
            {
                discount += 0.1;
            }

            if (isLoyalCustomer) discount += 0.05;

            if(promoCode != null)
            {
                if (promoCode.StartsWith(PROMO_PREFIX))
                {
                    double promoCodeDiscount = Convert.ToDouble(promoCode.Substring(PROMO_PREFIX.Length)) / 100;
                    discount += promoCodeDiscount;
                }
            }

            if(discount > 0.5)
            {
                discount = 0.5;
            }

            double shippingCost = orderPrice > 1000 ? 0 : shippingDistance * 10;

            discount = Math.Round(discount, 2);

            return orderPrice * (1 - discount) + shippingCost;
        }
    }
}
