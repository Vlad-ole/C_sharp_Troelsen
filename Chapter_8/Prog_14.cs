using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать фабрику класса.

namespace Chapter_8
{
    class MyClass
    {
        int a, b; // закрытые члены класса
        // Создать фабрику для класса MyClass.
        public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;
            return t; // возвратить объект
        }
        public void Show()
        {
            Console.WriteLine("а и b: " + a + " " + b);
        }
    }
    
    class Prog_14
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            int i, j;
            // Сформировать объекты, используя фабрику класса.
            for (i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass anotherOb = ob.Factory(i, j); // создать объект
                anotherOb.Show();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
