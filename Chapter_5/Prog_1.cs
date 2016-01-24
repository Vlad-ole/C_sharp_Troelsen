using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Определить, является ли числовое значение положительным или отрицательным.

namespace Chapter_5
{
    class Prog_1
    {
        static void Main()
        {
            int i;
            for (i = -5; i <= 5; i++)
            {
                Console.Write("Проверка " + i);
                if (i < 0) Console.WriteLine("отрицательное число");
                else Console.WriteLine("положительное число");
            }

            Console.ReadKey();
        }
    }
}
