using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать оператор цикла foreach.

namespace Chapter_7
{
    class Prog_15
    {
        static void Main() 
        {
            int sum = 0;
            int[] nums = new int[10];
            // Задать первоначальные значения элементов массива nums.
            for (int i = 0; i < 10; i++)
                nums[i] = i;
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
