using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
В этой программе предпринимается попытка объявить во внутренней
области действия переменную с таким же самым именем, как и у
переменной, определенной во внешней области действия.
 * *** Эта программа не может быть скомпилирована. ***
*/

namespace Chapter_3
{
    class Prog_16
    {
        static void Main() 
        {
        int count;
        for (count = 0; count < 10; count = count+1) 
        {
            Console.WriteLine("Это подсчет: " + count);
            int count; // Недопустимо!!!
            for(count = 0; count < 2; count++)
            Console.WriteLine("В этой программе есть ошибка!");
        }        
    }
}
