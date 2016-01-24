using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Сгенерировать исключение вручную.

namespace Chapter_13
{
     
    class Prog_9
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("До генерирования исключения.");
                throw new DivideByZeroException();
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Исключение перехвачено.");
            }

            Console.WriteLine("После пары операторов try/catch.");

            Console.ReadKey();
        }
    }
}
