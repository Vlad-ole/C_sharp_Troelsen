using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать управление оператором switch посредством строк.

namespace Chapter_7
{
    class Prog_24
    {
        static void Main()
        {
            string[] strs = { "один", "два", "три", "два", "один" };
            foreach (string s in strs)
            {
                switch (s)
                {
                    case "один":
                        Console.Write(1);
                        break;
                    case "два":
                        Console.Write(2);
                        break;
                    case "три":
                        Console.Write(3);
                        break;
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
