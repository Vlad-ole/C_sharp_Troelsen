using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить оператор break во вложенных циклах.

namespace Chapter_5
{
    class Prog_22
    {
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Подсчет во внешнем цикле: " + i);
                Console.Write(" Подсчет во внутреннем цикле: ");
                int t = 0;
                while (t < 100)
                {
                    if (t == 10) break; // прервать цикл, если t равно 10
                    Console.Write(t + " ");
                    t++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Циклы завершены.");

            Console.ReadKey();
        }
    }
}
