using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вычислить порядок величины целого числа.

namespace Chapter_5
{
    class Prog_16
    {
        static void Main()
        {
            int num;
            int mag;
            num = 435679;
            mag = 0;
            Console.WriteLine("Число: " + num);
            while (num > 0)
            {
                mag++;
                num = num / 10;
            };
            Console.WriteLine("Порядок величины: " + mag);

            Console.ReadKey();
        }
    }
}
