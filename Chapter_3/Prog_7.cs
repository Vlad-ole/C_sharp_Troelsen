using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение типа bool.

namespace Chapter_3
{
    class Prog_7
    {
        static void Main()
        {
            bool b;
            b = false;
            Console.WriteLine("b равно " + b);
            b = true;
            Console.WriteLine("b равно " + b);
            // Логическое значение может управлять оператором if.
            if (b) Console.WriteLine("Выполняется.");
            b = false;
            if (b) Console.WriteLine("He выполняется.");
            // Результатом выполнения оператора отношения
            // является логическое значение.
            Console.WriteLine("10 > 9 равно " + (10 > 9));

            Console.ReadKey();
        }
    }
}
