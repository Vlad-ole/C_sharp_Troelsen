using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать тип byte.

namespace Chapter_3
{
    class Prog_2
    {
        static void Main()
        {
            byte x;
            int sum;
            sum = 0;
            for (x = 1; x <= 100; x++)
                sum = sum + x;
            Console.WriteLine("Сумма чисел от 1 до 100 равна " + sum);

            Console.ReadKey();
        }
    }
}
