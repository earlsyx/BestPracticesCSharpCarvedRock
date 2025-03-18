using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.DRY
{
    internal class DRY
    {
        public DRY()
        {
            BackPack backPack = new BackPack("Tor 85 Litre Rucksack", 79.99, 85, 200, true);
            Shoes shoes = new Shoes("Salomon X Ultra", 119, 10, "black", true);

            backPack.Price = PriceWithDiscount(backPack.Price);
            shoes.Price = PriceWithDiscount(shoes.Price);
        }
        public static double PriceWithDiscount(double price)
        {
            if ((price > 100) && (price < 400))
            {
                price -= price * 0.30;
            }
            else if (price >= 400)
            {
                price -= price * 0.60;
            }
            return price;
        }
    }
}
