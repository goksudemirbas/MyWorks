using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string[] cities = new string[2] { "İstanbul", "Ankara" };

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Bolu");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("Rize");
            Console.WriteLine(cities[2]); //sayı ya da char eklenebilir.
            Console.ReadLine();

        }
    }
}
