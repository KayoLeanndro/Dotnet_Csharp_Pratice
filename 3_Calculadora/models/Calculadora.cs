using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Calculadora.models
{
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }

        public double RestoDivisao(double n1, double n2)
        {
            return n1 % n2;
        }

        public double Potenciacao(double n1, double n2)
        {
            return Math.Pow(n1,n2);
        }



    }
}