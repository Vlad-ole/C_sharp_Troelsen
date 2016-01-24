using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать запятые в операторе цикла for.

namespace Chapter_5
{
    class Prog_9
    {
        static void Main()
        {
            int i, j;
            for (i = 0, j = 10; i < j; i++, j--)
                Console.WriteLine("i и j: " + i + " " + j);

            Console.ReadKey();
        }


    }
}
