using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinome
{
    public class Polinome
    {
        /// <summary>
        /// Массив коэффициентов полинома
        /// </summary>
        public double[] X;

        /// <summary>
        /// 
        /// </summary>
        public int Order
        {
            get 
            {
                return X.Length - 1;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Polinome() { }

        /// <summary>
        /// Конструктор с заданием массива коэффициентов
        /// </summary>
        /// <param name="X"></param>
        public Polinome(double[] X)
        {
            this.X = X;
        }

        /// <summary>
        /// Переопределение метода "ToString"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string S = "";
            for (int i = Order; i > 0; i--)
            {
                if (X[i] != 0)
                {
                    if (i < Order) if (X[i] < 0)
                        S = S.Remove(S.Length - 3, 3) + " - ";
                    if (X[i] != 0 && X[i] != 1) S += Math.Abs(X[i]);
                    if (i != 1) S += "x^" + i;
                    else S += "x";
                    S += " + ";
                }
            }
            if (X[0] != 0) return S += X[0];
            else return S.Remove(S.Length - 3, 3);
        }

        /// <summary>
        /// Возвращает значение функции в заданой точке
        /// </summary>
        /// <param name="X">Заданая точка</param>
        /// <returns></returns>
        public double Value(double X)
        {
            double y = 0;
            for (int i = 0; i < this.X.Length; i++)
            {
                y += this.X[i] * Math.Pow(X, i);
            }
            return y;
        }

        /// <summary>
        /// Сложение двух полиномов
        /// </summary>
        /// <param name="P2"></param>
        public void Add(Polinome P2)
        {
            if (Order < P2.Order)
            {
                Array.Resize<double>(ref this.X, P2.X.Length);
                for (int i = Order + 1; i < P2.Order + 1; i++)
                    X[i] = 0;
            }
            for (int i = 0; i < P2.Order + 1; i++)
            {
                this.X[i] += P2.X[i];
            }
        }

        /// <summary>
        /// Вычитание двух полиномов
        /// </summary>
        /// <param name="P2"></param>
        public void Sub(Polinome P2)
        {
            if (Order < P2.Order)
            {
                Array.Resize<double>(ref this.X, P2.X.Length);
                for (int i = Order + 1; i < P2.Order + 1; i++)
                    X[i] = 0;
            }
            for (int i = 0; i < P2.Order + 1; i++)
            {
                this.X[i] -= P2.X[i];
            }
        }

        /// <summary>
        /// Умножение двух полиномов
        /// </summary>
        /// <param name="P2"></param>
        public void Mul(Polinome P2)
        {
            double[] NewX = new double[Order + P2.Order + 1];
            for (int i = 0; i < Order + 1; i++)
                for (int j = 0; j < P2.Order + 1; j++)
                {
                    NewX[i + j] += this.X[i] * P2.X[j];
                }
            this.X = NewX;
        }

        public void Div(Polinome P2, out Polinome Remainder)
        {
            Remainder = this;
            Polinome Quotient = new Polinome(new double[Remainder.X.Length - P2.X.Length + 1]);
            for (int i = 0; i < Quotient.X.Length; i++)
            {
                double coeff = Remainder.X[Remainder.X.Length - i - 1] / P2.X[P2.X.Length - 1];
                Quotient.X[Quotient.X.Length - i - 1] = coeff;
                for (int j = 0; j < P2.X.Length; j++)
                {
                    Remainder.X[Remainder.X.Length - i - j - 1] -= coeff * P2.X[P2.X.Length - j - 1];
                }
            }
            this.X = Quotient.X;
        }

        /// <summary>
        /// Вычисление корней полинома
        /// </summary>
        public void GetRoot()
        { 
        }
    }
}
