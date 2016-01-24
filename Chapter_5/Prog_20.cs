using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить оператор break для выхода из цикла do-while.

namespace Chapter_5
{
    class Prog_20
    {
        static void Main()
        {
            int i;
            i = -10;
            do
            {
                if (i > 0) break;
                Console.Write(i + " ");
                i++;
            } while (i <= 10);
            Console.WriteLine("Готово!");

            Console.ReadKey();
        }
    }
}
