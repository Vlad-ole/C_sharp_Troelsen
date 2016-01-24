using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вычислить среднее арифметическое ряда значений.

namespace Chapter_7
{
    class Prog_3
    {
        static void Main()
        {
            //int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };//var 1

            //int[] nums = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 }; // var 2

            //int[] nums; nums = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };//var 3

            int[] nums = new int[10] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49}; //var 4

            int avg = 0;
            for (int i = 0; i < 10; i++)
                avg = avg + nums[i];
            avg = avg / 10;
            Console.WriteLine("Среднее: " + avg);

            Console.ReadKey();
        }
    }
}
