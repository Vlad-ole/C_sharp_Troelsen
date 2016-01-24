using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Простой пример, демонстрирующий применение инициализаторов объектов.

namespace Chapter_8
{
    class MyClass
    {
        public int Count;
        public string Str;
    }
    
    class Prog_22
    {
        static void Main()
        {
            // Сконструировать объект типа MyClass, используя инициализаторы объектов.
            MyClass obj = new MyClass { Count = 100, Str = "Тестирование" };
            Console.WriteLine(obj.Count + " " + obj.Str);

            Console.ReadKey();
        }
    }
}
