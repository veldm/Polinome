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
            Polinome.Polinome NewP = P;
            NewP.Mul(P2);
            Console.WriteLine(NewP.ToString());
            NewP = P;
            NewP.Add(P2);
            Console.WriteLine(NewP.ToString());
            NewP = P;
            NewP.Sub(P2);
            Console.WriteLine(NewP.ToString());
            NewP = P;
            NewP.Div(P2, out Polinome.Polinome Remainder);
            Console.WriteLine(NewP.ToString());
            Console.WriteLine(Remainder.ToString());
            for (; ; ) ;
        }
    }
}
