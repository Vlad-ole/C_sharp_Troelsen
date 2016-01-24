using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить оператор break для выхода из цикла.

namespace Chapter_5
{
    class Prog_19
    {
        static void Main()
        {
            // Использовать оператор break для выхода из этого цикла.
            for (int i = -10; i <= 10; i++)
            {
                if (i > 0) break; // завершить цикл, как только значение
                // переменной i станет положительным
                Console.Write(i + " ");
            }
            Console.WriteLine("Готово!");

            Console.ReadKey();
        }
    }
}
