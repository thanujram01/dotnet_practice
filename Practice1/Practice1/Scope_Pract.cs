using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Scope_Pract
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Thanuj";
            bool isWorking = true;

            var number2 = 2;
            var count2 = 10;
            var totalPrice2 = 20.95f;
            var character2 = 'A';
            var firstName2 = "Thanuj";
            var isWorking2 = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine(number2);
            Console.WriteLine(count2);
            Console.WriteLine(totalPrice2);
            Console.WriteLine(character2);
            Console.WriteLine(firstName2);
            Console.WriteLine(isWorking2);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
