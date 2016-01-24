using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать свойство Length трехмерного массива.

namespace Chapter_7
{
    class Prog_11
    {
        static void Main()
        {
            int[, ,] nums = new int[10, 5, 6];
            Console.WriteLine("Длина массива nums равна " + nums.Length);

            Console.ReadKey();
        }
    }
}
