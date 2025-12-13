using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Type_cast_Pract
    {
        public static void Main(string[] args)
        {
            // byte < int so there wont be any issue in this casting (implicit)
            byte i = 1;
            int b = i;

            // gives error
            int j = 1;
            //byte c = j; - gives error
            byte c = (byte)j; //explicit casting

            int x = 1;
            float y = x;

            string s = "1";
            // int s2 = (int)s; this will give an error
            int i3 = Convert.ToInt32(s);
            int j3 = int.Parse(s);
        }
    }
}
