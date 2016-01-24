using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Поменять местами два значения.

namespace Chapter_8
{
    class ValueSwap
    {
        // Этот метод меняет местами свои аргументы.
        public void Swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
    }
    
    class Prog_7
    {
        static void Main()
        {
            ValueSwap ob = new ValueSwap();
            int x = 10, y = 20;
            Console.WriteLine("x и у до вызова: " + x + " " + y);
            ob.Swap(ref x, ref y);
            Console.WriteLine("х и у после вызова: " + x + " " + y);

            Console.ReadKey();
        }
    }
}
