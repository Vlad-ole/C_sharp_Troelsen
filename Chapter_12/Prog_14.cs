using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение перечисления.
namespace Chapter_12
{
    class Prog_14
    {
        enum Apple
        {
            Jonathan, GoldenDel, RedDel, Winesap,
            Cortland, McIntosh
        };

        static void Main()
        {
            string[] color = 
            {
                "красный",
                "желтый",
                "красный",
                "красный",
                "красный",
                "красновато-зеленый"
            };

            Apple i; // объявить переменную перечислимого типа
            // Использовать переменную i для циклического
            // обращения к членам перечисления.
            for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
                Console.WriteLine(i + " имеет значение " + (int)i);
            Console.WriteLine();

            // Использовать перечисление для индексирования массива.
            for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
                Console.WriteLine("Цвет сорта " + i + " — " +
                color[(int)i]);

            Console.ReadKey();
        }
    }
}
