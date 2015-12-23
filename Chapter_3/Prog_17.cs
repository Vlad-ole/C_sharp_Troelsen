using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать неявное преобразование типа long в тип double.

namespace Chapter_3
{
    class Prog_17
    {
        static void Main()
        {
            long L;
            double D;
            L = 100123285L;
            D = L;
            Console.WriteLine("L и D: " + L + " " + D);

            Console.ReadKey();
        }
    }
}
