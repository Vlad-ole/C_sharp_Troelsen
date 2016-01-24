using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение поразрядного унарного оператора НЕ.

namespace Chapter_4
{
    class Prog_12
    {
        static void Main()
        {
            sbyte b = -34;
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            // обратить все биты
            b = (sbyte)~b;
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }

            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
