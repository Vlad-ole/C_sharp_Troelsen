using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Поменять местами две ссылки.

namespace Chapter_8
{
    class RefSwap
    {
        int a, b;
        
        public RefSwap(int i, int j)
        {
            a = i;
            b = j;
        }
       
        public void Show()
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }
        // Этот метод изменяет свои аргументы.
        
        public void Swap(ref RefSwap ob1, ref RefSwap ob2)
        {
            RefSwap t;
            t = ob1;
            ob1 = ob2;
            ob2 = t;
        }
    }

    class Prog_10
    {
        static void Main()
        {
            RefSwap x = new RefSwap(1, 2);
            RefSwap y = new RefSwap(3, 4);

            Console.Write("x до вызова: ");
            x.Show();

            Console.Write("у до вызова: ");
            y.Show();
           
            Console.WriteLine();
            // Смена объектов, на которые ссылаются аргументы х и у.           
            x.Swap(ref x, ref y);

            Console.Write("х после вызова: ");           
            x.Show();
            
            Console.Write("у после вызова: ");
            y.Show();

            Console.ReadKey();
        }
    }
}
