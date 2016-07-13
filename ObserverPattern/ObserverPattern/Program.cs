using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product = new Product();

            Shop Shop1 = new Shop("Shop1");
            Shop Shop2 = new Shop("Shop2");
            Shop Shop3 = new Shop("Shop3");

            Product.AttachShop(Shop1);

            Product.AttachShop(Shop2);

           

            Product.ChangePrice(30.0f);
            Product.DetachShop(Shop3);

            Console.ReadLine();

            Console.WriteLine("Please enter the new price of the product");

            int intTemp = Convert.ToInt32(Console.ReadLine());
           
            Product.ChangePrice(intTemp);
        
            Console.Read();

        }



    }

  


}
