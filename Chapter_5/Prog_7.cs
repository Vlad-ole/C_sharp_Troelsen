using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Выполнение цикла for в отрицательном направлении.

namespace Chapter_5
{
    class Prog_7
    {
        static void Main()
        {
            int x;
            for (x = 100; x > -100; x -= 5)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
