using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> cities = new MyDictionary<int,string>();
            cities.Add(34,"İstanbul");
            cities.Add(48, "Muğla");
            cities.Add(35, "İzmir");
            cities.Add(06, "Ankara");
            Console.WriteLine(cities.Count);
        }
    }
}
