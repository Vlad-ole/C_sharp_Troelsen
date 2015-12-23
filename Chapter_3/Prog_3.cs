using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Определить радиус окружности по площади круга.

namespace Chapter_3
{
    class Prog_3
    {
        static void Main()
        {
            Double r;
            Double area;
            area = 10.0;
            r = Math.Sqrt(area / 3.1416);
            Console.WriteLine("Радиус равен " + r);

            Console.ReadKey();
        }
    }
}
