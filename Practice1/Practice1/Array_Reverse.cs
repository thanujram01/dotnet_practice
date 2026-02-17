using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Array_Reverse
    {
        public static void Main(string[] args)
        {
            int[] x = new int[] { 58, 26, 65, 48, 12, 89, 1, 3 };
            int[] y = new int[x.Length];

            for (int i = x.Length - 1; i >= 0; i--)
            {
                for(int j = y.Length - 1 - i; j < y.Length - i; j++)
                {
                    y[j] = x[i];
                }
            }

            Console.WriteLine(x.Length);

            foreach (int a in x)
            {
                Console.Write(a + ", ");
            }

            Console.WriteLine("\n");

            foreach (int a in y)
            {
                Console.Write(a + ", ");
            }
        }
    }
}
