using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Разделить только на четные, ненулевые значения.

namespace Chapter_4
{
    class Prog_16
    {
        static void Main()
        {
            for (int i = -5; i < 6; i++)
                if (i != 0 ? (i % 2 == 0) : false)
                    Console.WriteLine("100 / " + i + " равно " + 100 / i);

            Console.ReadKey();
        }
    }
}
