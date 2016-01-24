﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение деструктора.

namespace Chapter_6
{
    class Destruct
    {
        public int x;
        public Destruct(int i)
        {
            x = i;
        }
        // Вызывается при утилизации объекта.
        ~Destruct()
        {
            Console.WriteLine("Уничтожить " + x);
        }
        // Создает объект и тут же уничтожает его.
        public void Generator(int i)
        {
            Destruct о = new Destruct(i);
        }
    }

    class Prog_12
    {
        static void Main()
        {
            int count;
            Destruct ob = new Destruct(0);
            /* А теперь создать большое число объектов.
            В какой-то момент произойдет "сборка мусора".
            Примечание: для того чтобы активизировать
            "сборку мусора", возможно, придется увеличить
            число создаваемых объектов. */
            for (count = 1; count < 10000000; count++)
                ob.Generator(count);
            Console.WriteLine("Готово!");

            Console.ReadKey();
        }
    }
}
