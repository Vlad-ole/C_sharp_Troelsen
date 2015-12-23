using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение управляющих
// последовательностей символов в строковых литералах.

namespace Chapter_3
{
    class Prog_10
    {
        static void Main() 
        {
            Console.WriteLine("Первая строка\nВторая строка\nТретья строка");
            Console.WriteLine("Один\tДва\tТри");
            Console.WriteLine("Четыре\tПять\tШесть");
            // Вставить кавычки.
            Console.WriteLine("\"3ачем?\", спросил он.");

            Console.ReadKey();
        }
    }
}
