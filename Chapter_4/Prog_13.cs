using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение операторов сдвига.

namespace Chapter_4
{
    class Prog_13
    {
        static void Main()
        {
            int val = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val << 1; // сдвиг влево
            }
            Console.WriteLine();
            val = 128;
            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val >> 1; // сдвиг вправо
            }

            Console.ReadKey();
        }
    }
}
