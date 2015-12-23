using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать динамическую инициализацию.

namespace Chapter_3
{
    class Prog_12
    {
        static void Main()
        {
            // Длина сторон прямоугольного треугольника,
            double s1 = 4.0;
            double s2 = 5.0;
            // Инициализировать переменную hypot динамически,
            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Гипотенуза треугольника со сторонами " +
            s1 + " и " + s2 + " равна ");
            Console.WriteLine("{0:#.###}.", hypot);

            Console.ReadKey();
        }
    }
}
