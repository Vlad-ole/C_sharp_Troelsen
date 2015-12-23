using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// *** Эта программа не может быть скомпилирована. ***

namespace Chapter_3
{
    class Prog_18
    {
        static void Main()
        {
            long L;
            double D;
            D = 100123285.0;
            L = D; // Недопустимо!!!
            Console.WriteLine("L и D: " + L + " " + D);

            Console.ReadKey();
        }
    }
}
