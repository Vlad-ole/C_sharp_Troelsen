﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать массивы строк.

namespace Chapter_7
{
    class Prog_21
    {
        static void Main()
        {
            string[] str = { "Это", "очень", "простой", "тест." };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");
            Console.WriteLine("\n");
            // Изменить строку.
            str[1] = "тоже";
            str[3] = "до предела тест!";
            Console.WriteLine("Видоизмененный массив: ");
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");

            Console.ReadKey();
        }
    }
}
