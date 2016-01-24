using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Передача аргументов обычных типов по значению.

namespace Chapter_8
{
    class Test
    {
        /* Этот метод не оказывает никакого влияния на
        аргументы, используемые для его вызова. */
        public void NoChange(int i, int j)
        {
            i = i + j;
            j = -j;
        }
    }


    class Prog_4
    {
        static void Main()
        {
            Test ob = new Test();
            int a = 15, b = 20;
            Console.WriteLine("а и b до вызова: " +
            a + " " + b);
            ob.NoChange(a, b);
            Console.WriteLine("а и b после вызова: " +
            a + " " + b);

            Console.ReadKey();
        }
    }
}
