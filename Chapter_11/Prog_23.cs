using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пример упаковки при передаче значения методу.

namespace Chapter_11
{
    class BoxingDemo
    {
        static void Main()
        {
            int x;
            x = 10;
            Console.WriteLine("Значение x равно: " + x);
            
            // значение переменной x автоматически упаковывается
            // когда оно передается методу Sqr().
            x = BoxingDemo.Sqr(x);
            Console.WriteLine("Значение x в квадрате равно: " + х);
        }
        
        static int Sqr(object о)
        {
            return (int)о * (int)о;
        }
    }
}
