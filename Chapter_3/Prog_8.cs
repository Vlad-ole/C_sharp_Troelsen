using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить команды форматирования.

namespace Chapter_3
{
    class Prog_8
    {
        static void Main()
        {
            int i;
            Console.WriteLine("Число\tКвадрат\tКуб");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);

            Console.ReadKey();
        }
    }
}
