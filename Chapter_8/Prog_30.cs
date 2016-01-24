using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использовать модификатор static.

namespace Chapter_8
{
    class StaticDemo
    {
        // Переменная типа static.
        public static int Val = 100;
        
        // Метод типа static.
        public static int ValDiv2()
        {
            return Val / 2;
        }
    }

    //class StaticError
    //{
    //    public int Denom = 3; // обычная переменная экземпляра
    //    public static int Val = 1024; // статическая переменная
    //    /* Ошибка! Непосредственный доступ к нестатической
    //    переменной из статического метода недопустим. */
    //    static int ValDivDenom()
    //    {
    //        return Val / Denom; // не подлежит компиляции!
    //    }
    //}


    //class AnotherStaticError
    //{
    //    // Нестатический метод.
    //    void NonStaticMeth()
    //    {
    //        Console.WriteLine("В методе NonStaticMeth().");
    //    }
    //    /* Ошибка! Непосредственный вызов нестатического
    //    метода из статического метода недопустим. */
    //    static void staticMeth()
    //    {
    //        NonStaticMeth(); // не подлежит компиляции!
    //    }
    //}

    class MyClass
    {
        // Нестатический метод.
        void NonStaticMeth()
        {
            Console.WriteLine("В методе NonStaticMeth().");
        }

        /* Нестатический метод может быть вызван из
        статического метода по ссылке на объект. */
        public static void staticMeth(MyClass ob)
        {
            ob.NonStaticMeth(); // все верно!
        }
    }
    
    class Prog_30
    {
        static void Main()
        {
            Console.WriteLine("Исходное значение переменной " + "StaticDemo.Val равно " + StaticDemo.Val);
            StaticDemo.Val = 8;
            Console.WriteLine("Текущее значение переменной" + "StaticDemo.Val равно " + StaticDemo.Val);
            Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());

            Console.ReadKey();
        }
    }
}
