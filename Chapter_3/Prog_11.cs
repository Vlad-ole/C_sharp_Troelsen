using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение буквальных строковых литералов.

namespace Chapter_3
{
    class Prog_11
    {
        static void Main()
        {
            Console.WriteLine(@"Это буквальный
строковый литерал,
занимающий несколько строк.
");
            Console.WriteLine(@"А это вывод с табуляцией:
1 2 3 4
5 6 7 8
");
            Console.WriteLine(@"Отзыв программиста: ""Мне нравится С#.""");

            Console.ReadKey();
        }
    }
}
