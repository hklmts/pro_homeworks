using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw._2._1._5_hw
{
    public class Shop : IDisposable
    {
        public string ShopName { get; set; }
        public string ShopAdress { get; set; }
        public string ShopType { get; set; }

        public Shop(string shopName, string shopAdress, string shopType)
        {
            ShopName = shopName;
            ShopAdress = shopAdress;
            ShopType = shopType;
        }

        public void Dispose()
        {
            Console.WriteLine($"{ShopName} was deleted");
        }

        public void ShowShop()
        {
            Console.WriteLine($"Shop name {ShopName}, type: {ShopType}, address: {ShopAdress}");
        }
    }

/*    interface IDisposable
    { void Dispose(); }*/
}
