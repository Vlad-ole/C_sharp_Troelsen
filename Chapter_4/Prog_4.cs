﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Построение операции импликации в С#.

namespace Chapter_4
{
    class Prog_4
    {
        static void Main()
        {
            bool p = false, q = false;
            int i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    if (i == 0) p = true;
                    if (i == 1) p = false;
                    if (j == 0) q = true;
                    if (j == 1) q = false;
                    Console.WriteLine("p равно " + p + ", q равно " + q);
                    if (!p | q)
                        Console.WriteLine("Результат импликации " + p +
                        " и " + q + " равен " + true);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }


    }
}
