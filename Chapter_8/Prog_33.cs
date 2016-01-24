using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить статический конструктор.

namespace Chapter_8
{
    class Cons
    {
        public static int alpha;
        public int beta;

        // Статический конструктор.
        static Cons()
        {
            alpha = 99;
            Console.WriteLine("В статическом конструкторе.");
        }

        // Конструктор экземпляра.
        public Cons()
        {
            beta = 100;
            Console.WriteLine("В конструкторе экземпляра.");
        }
    }
    
    class Prog_33
    {
        static void Main()
        {
            Cons ob = new Cons();
            Console.WriteLine("Cons.alpha: " + Cons.alpha);
            Console.WriteLine("ob.beta: " + ob.beta);

            Console.ReadKey();
        }
    }
}
