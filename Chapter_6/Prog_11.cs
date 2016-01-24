using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать оператор new вместе с типом значения.

namespace Chapter_6
{
    class Prog_11
    {
        static void Main()
        {
            int i = new int(); // инициализировать переменную i нулевым значением
            Console.WriteLine("Значение переменной i равно: " + i);

            Console.ReadKey();
        }
    }
}
