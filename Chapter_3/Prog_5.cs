using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать тип decimal для расчета скидки.

namespace Chapter_3
{
    class Prog_5
    {
        static void Main()
        {
            decimal price;
            decimal discount;
            decimal discounted_price;
            // Рассчитать цену со скидкой.
            price = 19.95m;
            discount = 0.15m; // норма скидки составляет 15%
            discounted_price = price - (price * discount);
            Console.WriteLine("Цена со скидкой: $" + discounted_price);

            Console.ReadKey();
        }
    }
}
