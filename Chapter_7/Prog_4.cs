using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать превышение границ массива.

namespace Chapter_7
{
    class Prog_4
    {
        static void Main()
        {
            int[] sample = new int[10];
            int i;
            // Воссоздать превышение границ массива.
            for (i = 0; i < 100; i = i + 1)
                sample[i] = i;

            Console.ReadKey();
        }
    }
}
