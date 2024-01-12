using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraWF
{
    internal class Calculos
    {
      public static double soma (double primeiroValor, double segundoValor)
        {
            return primeiroValor + segundoValor;
        }

        public static double subtracao (double primeiroValor, double segundoValor)
        {
            return primeiroValor - segundoValor;
        }

        public static double divisao(double primeiroValor, double segundoValor)
        {
            return primeiroValor / segundoValor;
        }

        public static double multiplicacao(double primeiroValor, double segundoValor)
        {
            return primeiroValor * segundoValor;
        }

    }
}
