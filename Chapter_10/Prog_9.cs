using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить модификатор доступа в аксессоре.

namespace Chapter_10
{
    class PropAccess
    {
        int prop; // поле, управляемое свойством МуРrор
        public PropAccess() { prop = 0; }
        
        /* Это свойство обеспечивает доступ к закрытой переменной экземпляра prop.
        Оно разрешает получать значение переменной prop из любого кода,
        но устанавливать его — только членам своего класса. */
        public int МуРrор
        {
            get
            {
                return prop;
            }
            private set
            { // теперь это закрытый аксессор
                prop = value;
            }
        }
        
        // Этот член класса инкрементирует значение свойства МуРrор.
        public void IncrProp()
        {
            МуРrор++; // Допускается в. том же самом классе.
        }
    }

    // Продемонстрировать применение модификатора доступа в аксессоре свойства.
    class Prog_9
    {
        static void Main()
        {
            PropAccess ob = new PropAccess();
            
            Console.WriteLine("Первоначальное значение ob.МуРrор: " + ob.МуРrор);
            // ob.МуРrор = 100; // недоступно для установки
            
            ob.IncrProp();
            Console.WriteLine("Значение ob.МуРrор после инкрементирования: " + ob.МуРrор);

            Console.ReadKey();
        }
    }
}
