using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить поразрядный оператор ИЛИ, чтобы сделать число нечетным.

namespace Chapter_4
{
    class Prog_10
    {
        static void Main()
        {
            ushort num;
            ushort i;
            for (i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num: " + num);
                num = (ushort)(num | 1);
                Console.WriteLine("num после установки младшего разряда: " +
                num + "\n");
            }

            Console.ReadKey();
        }
    }
}
