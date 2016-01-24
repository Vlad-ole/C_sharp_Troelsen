using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить оператор continue.

namespace Chapter_5
{
    class Prog_23
    {
        static void Main()
        {
            // вывести четные числа от 0 до 100.
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0) continue; // перейти к следующему шагу итерации
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
