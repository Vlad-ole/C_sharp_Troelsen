﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Не сработает!

namespace Chapter_13
{
    class Prog_4
    {
        static void Main()
        {
            int[] nums = new int[4];
            
            try
            {
                Console.WriteLine("До генерирования исключения.");
                // Сгенерировать исключение в связи с выходом индекса за границы массива.
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
                }
                Console.WriteLine("He подлежит выводу");
            }

            /* Если перехват рассчитан на исключение DivideByZeroException,
            то перехватить ошибку нарушения границ массива не удастся. */
            catch (DivideByZeroException)
            {
                // Перехватить исключение.
                Console.WriteLine("Индекс вышел за границы массива!");
            }
            Console.WriteLine("После блока перехвата исключения.");

            Console.ReadKey();
        }
    }
}
