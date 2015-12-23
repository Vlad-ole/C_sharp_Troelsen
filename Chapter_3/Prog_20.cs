using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пример неожиданного результата продвижения типов!

namespace Chapter_3
{
    class Prog_20
    {
        static void Main()
        {
            byte b;
            b = 10;
            b = (byte)(b * b); // Необходимо приведение типов!!
            Console.WriteLine("b: " + b);

            Console.ReadKey();
        }
    }
}
