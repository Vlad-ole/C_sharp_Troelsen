using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Применить тип decimal для расчета будущей стоимости
капиталовложений.
*/

namespace Chapter_3
{
    class Prog_6
    {
        static void Main()
        {
            decimal amount;
            decimal rate_of_return;
            int years, i;
            amount = 1000.0M;
            rate_of_return = 0.07M;
            years = 10;
            Console.WriteLine("Первоначальные капиталовложения: $" + amount);
            Console.WriteLine("Норма прибыли: " + rate_of_return);
            Console.WriteLine("В течение " + years + " лет");
            for (i = 0; i < years; i++)
                amount = amount + (amount * rate_of_return);
            Console.WriteLine("Будущая стоимость равна $" + amount);

            Console.ReadKey();
        }
    }
}
