using System;

namespace ShoppingCartNew.services
{
    public class Shopping : IShopping
    {
        public double calculateappleCost(int quantity, double cost)
        {
            int totalfree = quantity / 3;
            return Math.Round((quantity - totalfree) * cost, 2) ;
        }

        public double calculateOrangeCost(int quantity, double cost)
        {
            return Math.Round(quantity * cost, 2);
        }
    }
}
