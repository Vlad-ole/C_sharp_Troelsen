using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Эта программа не подлежит компиляции.

namespace Chapter_11
{
    class X
    {
        int a;
        public X(int i) { a = i; }
    }

    class Y
    {
        int a;
        public Y(int i) { a = i; }
    }
    
    class Prog_13
    {
        static void Main()
        {
            X x = new X(10);
            X x2;
            Y y = new Y(5);
            x2 = x; // верно, поскольку оба объекта относятся к одному и тому же типу
            x2 = y; // ошибка, поскольку это разнотипные объекты

            Console.ReadKey();
        }
    }
}
