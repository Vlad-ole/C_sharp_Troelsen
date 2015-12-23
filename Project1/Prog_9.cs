using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вычислить сумму и произведение чисел от 1 до 10.

namespace Project1
{
    class Prog_9
    {
        static void Main()
        {
            int prod;
            int sum;
            int i;
            sum = 0;
            prod = 1;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }
            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Произведение равно " + prod);

            Console.ReadKey();
        }
    }
}
