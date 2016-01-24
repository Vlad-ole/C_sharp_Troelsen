using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать отличие между префиксной
// и постфиксной формами оператора инкремента (++).

namespace Chapter_4
{
    class Prog_2
    {
        static void Main()
        {
            int x, y;
            int i;
            x = 1;
            y = 0;
            Console.WriteLine("Ряд чисел, полученных " +
            "с помощью оператора у = у + х++;");
            for (i = 0; i < 10; i++)
            {
                y = y + x++; // постфиксная форма оператора ++
                Console.WriteLine(y + " ");
            }
            Console.WriteLine();
            x = 1;
            y = 0;
            Console.WriteLine("Ряд чисел, полученных " +
            "с помощью оператора у = у + ++х;");
            for (i = 0; i < 10; i++)
            {
                y = y + ++x; // префиксная форма оператора ++
                Console.WriteLine(y + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
