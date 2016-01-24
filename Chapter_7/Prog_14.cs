using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать неявно типизированный ступенчатый массив.

namespace Chapter_7
{
    class Prog_14
    {
        static void Main()
        {
            var jagged = new[] 
            {
                new[] { 1, 2, 3, 4 },
                new[] { 9, 8, 7 },
                new[] { 11, 12, 13, 14, 15 }
            };

            for (int j = 0; j < jagged.Length; j++)
            {
                for (int i = 0; i < jagged[j].Length; i++)
                    Console.Write(jagged[j][i] + " ");
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }

}
