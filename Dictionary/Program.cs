using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> cities = new MyDictionary<string>();
            cities.Add("İstanbul");
            Console.WriteLine(cities.Count);
        }
    }
}
