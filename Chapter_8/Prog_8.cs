using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать модификатор параметра out.

namespace Chapter_8
{
    class Decompose
    {
        /* Разделить числовое значение с плавающей точкой на
        целую и дробную части. */
        public int GetParts(double n, out double frac)
        {
            int whole;
            whole = (int)n;
            frac = n - whole; // передать дробную часть числа через параметр frac
            return whole; // возвратить целую часть числа
        }
    }
    
    class Prog_8
    {
        static void Main()
        {
            Decompose ob = new Decompose();
            int i;
            double f;
            i = ob.GetParts(10.125, out f);
            Console.WriteLine("Целая часть числа равна " + i);
            Console.WriteLine("Дробная часть числа равна " + f);

            Console.ReadKey();
        }
    }
}
