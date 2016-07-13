using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    abstract class ShopAsbtractClass
    {
        ArrayList ShopList = new ArrayList(); // first example of usage of observer pattern

        // attach the observer to the product
        public void AttachShop(Shop shop)
        {
            ShopList.Add(shop);
        }

        // detach the observer from the 
        public void DetachShop(Shop shop)
        {
            ShopList.Add(shop);
        }

        // notify the shop with the change of priceate
        public void Notify(float price)
        {
            foreach (Shop s in ShopList)
            {
                s.Update(price);
            }
        }

    }
}
