using ShoppingCartNew.services;
using Xunit;

namespace ShoppingCartNewTests
{
    public class ShoppingTests
    {
        private Shopping _shopping;

        public ShoppingTests()
        {
            _shopping = new Shopping();
        }

        [Fact]
        public void TestBuy2Get1DiscountForApple_ReturnDiscountValue()
        {
           
            double expected = 11.2;

            var appleCost = _shopping.calculateappleCost(3, 5.6);

            Assert.Equal(expected, appleCost);
        }

        [Fact]
        public void TestBuy2Get1DiscountForApple_ReturnNonDiscountedValue()
        {
          
            double expected = 11;

            var appleCost = _shopping.calculateappleCost(3, 5.6);

            Assert.NotEqual(expected, appleCost);
        }

        [Fact]
        public void TestBuy2Get1DiscountForAllProduct_ReturnTotalDiscountedValue()
        {
           
            double expected = 20.2;

            var appleCost = _shopping.calculateappleCost(3, 5.6);

            var orangeCost = _shopping.calculateOrangeCost(3, 3);

            Assert.Equal(expected, (appleCost + orangeCost));
        }

        [Fact]
        public void TestBuy2Get1DiscountForOrange_ReturnDiscountValue()
        {
            double expected = 15.6;

            var appleCost = _shopping.calculateOrangeCost(3, 5.2);

            Assert.Equal(expected, appleCost);
        }

        [Fact]
        public void TestBuy2Get1DiscountForOrange_ReturnNonDiscountedValue()
        {
            
            double expected = 11;

            var appleCost = _shopping.calculateOrangeCost(3, 5.6);

            Assert.NotEqual(expected, appleCost);
        }

    }
}
