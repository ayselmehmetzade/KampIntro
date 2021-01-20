using System;

namespace MethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20);

            int number1 = 20;
            int number2 = 100;
            var sonuc = Add3(ref number1, number2);
            Console.WriteLine("Sonuc :  "+sonuc);
            Console.WriteLine(number1);
            //Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            var sonuc = number1 + number2;
            return sonuc;
        }
    }
}
