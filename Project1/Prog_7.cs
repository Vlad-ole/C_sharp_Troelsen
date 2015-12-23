using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение оператора цикла for

namespace Project1
{
    class Prog_7
    {
        static void Main()
        {
            int count;
            for (count = 0; count < 5; count = count + 1)
                Console.WriteLine("Это подсчет: " + count);
            Console.WriteLine("Готово!");

            Console.ReadKey();
        }
    }
}
