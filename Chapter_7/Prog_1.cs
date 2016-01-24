using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать одномерный массив.

namespace Chapter_7
{
    class Prog_1
    {
        static void Main()
        {
            int[] sample = new int[10];
            int i;
            for (i = 0; i < 10; i = i + 1)
                sample[i] = i;
            for (i = 0; i < 10; i = i + 1)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);

            Console.ReadKey();
        }
    }
}
