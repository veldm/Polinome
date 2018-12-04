using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polinome;

namespace ConsoleTestApplication
{
    class Program
    {
        static Polinome.Polinome P
        {
            get
            {
                double[] X = { 2, 3, 2, 5 };
                return new Polinome.Polinome(X);
            }
        }

        static Polinome.Polinome P2
        {
            get
            {
                double[] X2 = { 2, 2, 5, 7 };
                return new Polinome.Polinome(X2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Исходные полиномы");
            Console.WriteLine(P.ToString());
            Console.WriteLine(P2.ToString());
            Polinome.Polinome NewP = P;
            Console.WriteLine("Умножение");
            NewP.Mul(P2);
            Console.WriteLine(NewP.ToString());
            NewP = P;
            Console.WriteLine("Сложение");
            NewP.Add(P2);
            Console.WriteLine(NewP.ToString());
            NewP = P;
            Console.WriteLine("Вычитание");
            NewP.Sub(P2);
            Console.WriteLine(NewP.ToString());
            NewP = P;
            NewP.Div(P2, out Polinome.Polinome Remainder);
            Console.WriteLine("Деление");
            Console.WriteLine(NewP.ToString());
            Console.WriteLine("Остаток от деления");
            Console.WriteLine(Remainder.ToString());
            for (; ; ) ;
        }
    }
}
