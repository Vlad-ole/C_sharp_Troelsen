using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Отобразить цифры целого числа в обратном порядке.

namespace Chapter_5
{
    class Prog_18
    {
        static void Main()
        {
            int num;
            int nextdigit;
            num = 10;
            Console.WriteLine("Число: " + num);
            Console.Write("Число в обратном порядке: ");
            do
            {
                nextdigit = num % 10;
                Console.Write(nextdigit);
                num = num / 10;
            } while (num > 0);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
