using hw1_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Money
    {

        private int full { get; set; }
        private int coin { get; set; }

        public Money(double value)
        {
            this.full = (int)value;
            this.coin = (int)(value * 100 % 100);
        }

        public void SavedValue()
        {
            Console.WriteLine($"{full}.{coin} $");
        }

        public void BuyProduct(Product product)
        {
            Money value = product.Price;
            int newFull = full - value.full;
            int newCoin = coin - value.coin;
            if (newCoin < 0)
            {
                newFull--;
                if (newFull < 0)
                {
                    throw new Exception("You have not enough money");
                }
                newCoin = 100 + newCoin;
            }
            full = newFull;
            coin = newCoin;
            Console.WriteLine($"You got product {product.Name}");
        }
    }
}
