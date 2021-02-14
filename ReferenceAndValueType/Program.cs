using System;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] { "Ankara", "Istanbul", "Rize" };
            string[] cities1 = new string[] { "Bursa", "Bolu", "Edirne" };
            cities1 = cities;

            Console.WriteLine(cities1[0]);
            Console.WriteLine(cities[0]);
            Console.ReadLine();
        }
    }
}
