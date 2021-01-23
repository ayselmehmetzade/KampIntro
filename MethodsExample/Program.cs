using System;
using System.Linq;

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

            //int number1 = 20;
            //int number2 = 100;
            //var sonuc = Add3(out number1, number2);
            //Console.WriteLine("Sonuc :  "+sonuc);
            //Console.WriteLine(number1);
            //Console.WriteLine(result);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(5,10,15));
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

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            var sonuc = number1 + number2;
            return sonuc;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
      

    }
}   
