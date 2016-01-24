﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать двумерный массив.

namespace Chapter_7
{
    class Prog_5
    {
        static void Main()
        {
            int t, i;
            int[,] table = new int[3, 4];
            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.Write(table[t, i] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
