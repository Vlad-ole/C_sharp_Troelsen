using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Отдельные части цикла for могут оставаться пустыми.

namespace Chapter_5
{
    class Prog_12
    {
        static void Main()
        {
            int i;
            for (i = 0; i < 10; )
            {
                Console.WriteLine("Проход №" + i);
                i++; // инкрементировать переменную управления циклом
            }

            Console.ReadKey();

        }
 
    }
}
