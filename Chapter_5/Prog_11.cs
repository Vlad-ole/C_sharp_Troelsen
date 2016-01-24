using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Условием выполнения цикла может служить любое выражение типа bool.

namespace Chapter_5
{
    class Prog_11
    {
        static void Main()
        {
            int i, j;
            bool done = false;
            for (i = 0, j = 100; !done; i++, j--)
            {
                if (i * i >= j) done = true;
                Console.WriteLine("i, j: " + i + " " + j);
            }

            Console.ReadKey();
        }
    }
}
