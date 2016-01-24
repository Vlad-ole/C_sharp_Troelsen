using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить метод Substring().

namespace Chapter_7
{
    class Prog_23
    {
        static void Main()
        {
            string orgstr = "В C# упрощается обращение со строками.";
            // сформировать подстроку
            string substr = orgstr.Substring(5, 20);
            Console.WriteLine("orgstr: " + orgstr);
            Console.WriteLine("substr: " + substr);

            Console.ReadKey();
        }
    }
}
