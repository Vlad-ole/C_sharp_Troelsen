using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать ссылки на объекты определенного класса.

namespace Chapter_12
{
    // Создать класс.
    class MyClass
    {
        public int x;
    }

    // Показать присваивание разных объектов данного класса.
    class Prog_12
    {
        static void Main()
        {
            MyClass a = new MyClass();
            MyClass b = new MyClass();

            a.x = 10;
            b.x = 20;
            Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

            a = b;
            b.x = 30;
            Console.WriteLine("а.х {0}, b.x {1}", a.x, b.x);

            Console.ReadKey();
        }
    }
}
