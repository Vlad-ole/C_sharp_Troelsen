﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Зашифровать и расшифровать сообщение, используя
// простой подстановочный шифр.

namespace Chapter_8
{
    class Prog_27
    {
        static int Main(string[] args)
        {
            // Проверить наличие аргументов.
            if (args.Length < 2)
            {
                Console.WriteLine("ПРИМЕНЕНИЕ: " +
                "слово1: <зашифровать>/<расшифровать> " +
                "[слово2... словоN]");
                Console.ReadKey();
                return 1; // возвратить код неудачного завершения программы
            }

            // Если аргументы присутствуют, то первым аргументом должно быть
            // слово <зашифровать> или же слово <расшифровать>.
            if (args[0] != "зашифровать" & args[0] != "расшифровать")
            {
                Console.WriteLine("Первым аргументом должно быть слово " +
                "<зашифровать> или <расшифровать>.");
                Console.ReadKey();
                return 1; // возвратить код неудачного завершения программы
            }

            // Зашифровать или расшифровать сообщение.
            for (int n = 1; n < args.Length; n++)
            {
                for (int i = 0; i < args[n].Length; i++)
                {
                    if (args[0] == "зашифровать")
                        Console.Write((char)(args[n][i] + 1));
                    else
                        Console.Write((char)(args[n][i] - 1));
                }
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.ReadKey();
            return 0;
            
        }
    }
}
