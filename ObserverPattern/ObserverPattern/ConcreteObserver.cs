using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;


namespace ObserverPattern
{
    class Shop : ObserverInterface
    {
        string ShopName = string.Empty;
        float Price = 0.0f; 
        
        public Shop (string ShopName)
        {
            this.ShopName = ShopName;
        }

        public void Update(float price)
        {
            this.Price = price;
            Console.WriteLine(@"Price at {0}  is now {1}", ShopName, Price);

        }
    }
}
