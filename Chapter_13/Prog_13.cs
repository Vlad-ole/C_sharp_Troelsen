﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать обработку исключения NullReferenceException.

namespace Chapter_13
{
    class X
    {
        int x;
        public X(int a)
        {
            x = a;
        }

        public int Add(X o)
        {
            return x + o.x;
        }
    }

    // Продемонстрировать генерирование и обработку
    // исключения NullReferenceException.
    class Prog_13
    {
        static void Main()
        {
            X p = new X(10);
            X q = null; // присвоить явным образом пустое значение переменной q
            int val;
            
            try
            {
                val = p.Add(q); // эта операция приведет к исключительной ситуации
            }
            
            catch (NullReferenceException)
            {
                Console.WriteLine("Исключение NullReferenceException!");
                Console.WriteLine("Исправление ошибки...\n");
                // А теперь исправить ошибку.
                q = new X(9);
                val = p.Add(q);
            }

            Console.WriteLine("Значение val равно {0}", val);

            Console.ReadKey();
        }
    }
}
