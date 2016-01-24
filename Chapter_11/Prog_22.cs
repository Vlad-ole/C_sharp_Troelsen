using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Простой пример упаковки и распаковки.

namespace Chapter_11
{

    class Prog_22
    {
        static void Main()
        {
            int x;
            object obj;
            x = 10;
            obj = x; // упаковать значение переменной х в объект
            int у = (int)obj; // распаковать значение из объекта, доступного по
            // ссылке obj, в переменную типа int
            Console.WriteLine(у);

            Console.ReadKey();
        }
    }
}
