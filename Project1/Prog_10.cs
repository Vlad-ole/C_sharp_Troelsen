using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение идентификатора со знаком @.

namespace Project1
{
    class Prog_10
    {
        static void Main()
        {
            int @if; // применение ключевого слова if
            // в качестве идентификатора
            for (@if = 0; @if < 10; @if++)
                Console.WriteLine("@if равно " + @if);

            Console.ReadKey();
        }
    }
}
