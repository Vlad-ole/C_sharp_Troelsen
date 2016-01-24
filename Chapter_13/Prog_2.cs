using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Исключение может быть сгенерировано одним методом
и перехвачено другим. */

namespace Chapter_13
{
    class ExcTest
    {
        // Сгенерировать исключение.
        public static void GenException()
        {
            int[] nums = new int[4];
            Console.WriteLine("До генерирования исключения.");

            // Сгенерировать исключение в связи с выходом индекса за границы массива.
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums [{0}] : {1}", i, nums[i]);
            }
            Console.WriteLine("He подлежит выводу");
        }
    }


    class Prog_2
    {
        static void Main()
        {
            try
            {
                ExcTest.GenException();
            }

            catch (IndexOutOfRangeException)
            {
                // Перехватить исключение.
                Console.WriteLine("Индекс вышел за границы массива!");
            }

            Console.WriteLine("После блока перехвата исключения.");

            Console.ReadKey();
        }
    }
}
