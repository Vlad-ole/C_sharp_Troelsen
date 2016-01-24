using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Создать и вывести символьную строку.

namespace Chapter_7
{
    class Prog_19
    {
        static void Main()
        {
            char[] charray = { 'Э', 't', 'o', ' ', 'с', 't', 'p', 'o', 'к', 'a' };
            string strl = new string(charray);
            string str2 = "Еще одна строка.";
            Console.WriteLine(strl);
            Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}
