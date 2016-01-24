using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить поразрядный оператор И, чтобы сделать число четным.

namespace Chapter_4
{
    class Prog_7
    {
        static void Main()
        {
            ushort num;
            ushort i;
            for (i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num: " + num);
                num = (ushort)(num & 0xFFFE);
                Console.WriteLine("num после сброса младшего разряда: "
                + num + "\n");
            }

            Console.ReadKey();
        }
    }
}
