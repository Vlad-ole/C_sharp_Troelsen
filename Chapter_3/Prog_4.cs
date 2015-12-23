using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение тригонометрических функций.

namespace Chapter_3
{
    class Prog_4
    {
        static void Main()
        {
            Double theta; // угол в радианах
            for (theta = 0.1; theta <= 1.0;
            theta = theta + 0.1)
            {
                Console.WriteLine("Синус угла " + theta +
                " равен " + Math.Sin(theta));
                Console.WriteLine("Косинус угла " + theta +
                " равен " + Math.Cos(theta));
                Console.WriteLine("Тангенс угла " + theta +
                " равен " + Math.Tan(theta));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
