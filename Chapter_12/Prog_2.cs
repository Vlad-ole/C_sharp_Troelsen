using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Реализовать интерфейс ISeries и добавить в
// класс ByTwos метод GetPrevious().

namespace Chapter_12
{
    public interface ISeries
    {
        int GetNext(); // возвратить следующее по порядку число
        void Reset(); // перезапустить
        void SetStart(int х); // задать начальное значение
    }
    
    class ByTwos : ISeries
    {
        int start;
        int val;
        int prev;

        public ByTwos()
        {
            start = 0;
            val = 0;
            prev = -2;
        }

        public int GetNext()
        {
            prev = val;
            val += 2;
            return val;
        }

        public void Reset()
        {
            val = start;
            prev = start - 2;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
            prev = val - 2;
        }

        // Метод, не указанный в интерфейсе ISeries.
        public int GetPrevious()
        {
            return prev;
        }
    }
    
    class Prog_2
    {
        static void Main()
        {
            ByTwos ob = new ByTwos();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());
            Console.WriteLine("\nСбросить");
            ob.Reset();

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());

            Console.WriteLine("\nНачать с числа 100");
            ob.SetStart(100);

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());

            Console.ReadKey();
        }
    }
}
