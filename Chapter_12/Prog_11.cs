using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Скопировать структуру.

namespace Chapter_12
{
    // Определить структуру.
    struct MyStruct
    {
        public int x;
    }

    // Продемонстрировать присваивание структуры.
    class Prog_11
    {
        static void Main()
        {
            MyStruct a;
            MyStruct b;

            a.x = 10;
            b.x = 20;
            Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

            a = b;
            b.x = 30;
            Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

            Console.ReadKey();
        }
    }
}
