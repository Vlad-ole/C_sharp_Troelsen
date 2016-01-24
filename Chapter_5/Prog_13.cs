using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Исключить еще одну часть из определения цикла for.

namespace Chapter_5
{
    class Prog_13
    {
        static void Main()
        {
            int i;
            i = 0; // исключить инициализацию из определения цикла
            for (; i < 10; )
            {
                Console.WriteLine("Проход №" + i);
                i++; // инкрементировать переменную управления циклом
            }

            Console.ReadKey();
        }
    }
}
