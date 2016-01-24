using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить инициализаторы объектов в свойствах.

namespace Chapter_10
{
    class MyClass
    {
        // Теперь это свойства.
        public int Count { get; set; }
        public string Str { get; set; }
    }
    
    class Prog_8
    {
        static void Main()
        {
            // Сконструировать объект типа MyClass с помощью инициализаторов объектов.
            MyClass obj = new MyClass { Count = 100, Str = "Тестирование" };
            Console.WriteLine(obj.Count + " " + obj.Str);

            Console.ReadKey();
        }
    }
}
