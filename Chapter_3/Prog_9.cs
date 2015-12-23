using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать спецификатор формата С для вывода
// результата в местной валюте.

namespace Chapter_3
{
    class Prog_9
    {
        static void Main()
        {
            decimal price;
            decimal discount;
            decimal discounted_price;
            // рассчитать цену со скидкой,
            price = 19.95m;
            discount = 0.15m; // норма скидки составляет 15%
            discounted_price = price - (price * discount);
            Console.WriteLine("Цена со скидкой: {0:C}", discounted_price);

            Console.ReadKey();
        }
    }
}
