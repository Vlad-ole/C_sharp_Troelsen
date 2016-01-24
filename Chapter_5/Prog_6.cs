using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пример "проваливания" пустых ветвей case.

namespace Chapter_5
{
    class Prog_6
    {
        static void Main()
        {
            int i;
            for (i = 1; i < 5; i++)
                switch (i)
                {
                    case 1:
                    case 2:
                    case 3: Console.WriteLine("i равно 1, 2 или 3");
                        break;
                    case 4: Console.WriteLine("i равно 4");
                        break;
                }

            Console.ReadKey();
        }
    }
}
