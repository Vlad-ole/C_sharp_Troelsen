using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать оператор цикла foreach для обращения к двумерному массиву.

namespace Chapter_7
{
    class Prog_17
    {
        static void Main()
        {
            int sum = 0;
            int[,] nums = new int[3, 5];
            // Задать первоначальные значения элементов массива nums.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    nums[i, j] = (i + 1) * (j + 1);
            // Использовать цикл foreach для вывода значений
            // элементов массива и подсчета их суммы.
            foreach (int х in nums)
            {
                Console.WriteLine("Значение элемента равно: " + х);
                sum += х;
            }
            Console.WriteLine("Сумма равна: " + sum);

            Console.ReadKey();
        }
    }
}
