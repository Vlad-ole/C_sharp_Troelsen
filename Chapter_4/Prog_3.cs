﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение операторов
// отношения и логических операторов.

namespace Chapter_4
{
    class Prog_3
    {
        static void Main()
        {
            int i, j;
            bool b1, b2;
            i = 10;
            j = 11;
            if (i < j) Console.WriteLine("i < j");
            if (i <= j) Console.WriteLine("i <= j");
            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("Нельзя выполнить");
            if (i >= j) Console.WriteLine("Нельзя выполнить");
            if (i > j) Console.WriteLine("Нельзя выполнить");
            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("Нельзя выполнить");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) — true");
            if (b1 | b2) Console.WriteLine("b1 | b2 - true");
            if (b1 ^ b2) Console.WriteLine("bl ^ b2 — true");

            Console.ReadKey();
        }
    }
}
