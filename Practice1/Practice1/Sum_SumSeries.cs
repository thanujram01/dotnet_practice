using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Sum_SumSeries
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Enter a Number:");
            int x = Convert.ToInt32(Console.ReadLine());

            
            int s_sum = 0;

            for(int i = x; i > 0; i--)
            {
                int sum = 0;

                for (int j = x - i; j > 0; j--)
                {
                    sum = sum + j;
                }

                s_sum = s_sum + sum;
            }

            Console.WriteLine("Sum of Sum Series: " + s_sum);

        }
    }
}
