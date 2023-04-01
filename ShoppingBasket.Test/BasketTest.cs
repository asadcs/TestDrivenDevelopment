using NUnit.Framework;
using System.Collections.Generic;

namespace ShoppingBasket.Test
{
    public class BasketTest
    {
        [Test]
        public void TotalOfEmptyBasket()
        {
            Basket basket = new Basket(new List<Item>());
            Assert.AreEqual(0.0, basket.Total);
        }
        [Test]
        public void TotalOfSingleItem()
        {
            Basket basket = new Basket(new List<Item> { new Item(1, 100.0) });
            Assert.AreEqual(100.0, basket.Total);
        }
        [Test]
        public void TotalofTwoItems()
        {
            Basket basket = new Basket(new List<Item>() {
            new Item(1,100.00),
            new Item(2,200.00)
            });

            Assert.AreEqual(500.00, basket.Total);
        }
        [Test]
        public void TotalOfQuantityOfTwo()
        {
            Basket basket = new Basket(new List<Item>()
            {
                new Item(2,100.00)
            });

            Assert.AreEqual(200.00, basket.Total);
        }
    }
}