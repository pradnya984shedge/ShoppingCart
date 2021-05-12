using System;
using ShoppingCartNew.services;

namespace ShoppingCartNew
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IShopping shopping = new Shopping();

               // Type your username and press enter

                Console.WriteLine("Single Apple cost:");

                string costforApple = Console.ReadLine();

                Console.WriteLine("Enter Quantity for Apple:");

                // Create a string variable and get user input from the keyboard and store it in the variable
                string appquantity = Console.ReadLine();

                Console.WriteLine("Single orange cost:");

                string costfororange = Console.ReadLine();

              Console.WriteLine("Enter Quantity for Orange:");

                string orangequantity = Console.ReadLine();

                double totalApplecost = shopping.calculateappleCost(Convert.ToInt32(appquantity), Convert.ToDouble(costforApple));

                double totalorangeCost = shopping.calculateOrangeCost(Convert.ToInt32(orangequantity), Convert.ToDouble(costfororange));

                Console.WriteLine("TotalCost  is: " + (totalApplecost + totalorangeCost));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
