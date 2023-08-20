using hw1_.hw._2._1._5_hw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw5
{
    public class ModernShop : Shop
    {
        public ModernShop(string shopName, string shopAdress, string shopType) : base(shopName, shopAdress, shopType)
        {
        }

        ~ModernShop() 
        {
            base.Dispose();
        }

    }
}
