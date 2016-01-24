using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Показать биты, составляющие байт.

namespace Chapter_4
{
    class Prog_9
    {
        static void Main()
        {
            int t;
            byte val;
            val = 123;
            for (t = 128; t > 0; t = t / 2)
            {

                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }

            Console.ReadKey();
        }
    }
}
