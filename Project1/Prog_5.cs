using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вычислить площадь круга.

namespace Project1
{
    class Prog_5
    {
        static void Main()
        {
            double radius;
            double area;
            radius = 10.0;
            area = radius * radius * 3.1416;
            Console.WriteLine("Площадь равна " + area);
            Console.ReadKey();
        }
    }
}
