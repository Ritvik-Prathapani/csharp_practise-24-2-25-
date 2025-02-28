using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double totalAmount);
    }
    public class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double totalAmount) => totalAmount;
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly double _percentage;
        public PercentageDiscount(double percentage) => _percentage = percentage;

        public double ApplyDiscount(double totalAmount) => totalAmount - (totalAmount * _percentage / 100);
    }

    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly double _discountAmount;
        public FixedAmountDiscount(double discountAmount) => _discountAmount = discountAmount;

        public double ApplyDiscount(double totalAmount) => Math.Max(0, totalAmount - _discountAmount);
    }
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateTotal(double totalAmount)
        {
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }


}
