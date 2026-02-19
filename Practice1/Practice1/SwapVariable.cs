using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class SwapVariable
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Value for X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for Y");
            int y = Convert.ToInt32(Console.ReadLine());

            x = x - y;
            y = x + y;
            x = y - x;


            Console.WriteLine("Swapped Value of X - " + x);
            Console.WriteLine("Swapped Value of Y - " + y);
        }
    }
}
