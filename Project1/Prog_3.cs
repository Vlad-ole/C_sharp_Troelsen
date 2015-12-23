using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Prog_3
    {
        static void Main()
        {
            int x; // здесь объявляется переменная
            int y; // здесь объявляется еще одна переменная
            x = 100; // здесь переменной х присваивается значение 100
            Console.WriteLine("х содержит " + x);
            y = x / 2;
            Console.Write("у содержит х / 2: ");
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
