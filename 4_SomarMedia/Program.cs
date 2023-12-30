using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SomaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos valores deseja informar:");
            int quantidadeDeValores = int.Parse(Console.ReadLine());

            var listaDeValores = ColetarValores(quantidadeDeValores);

            // No lugar dos métodos abaixo você usar a biblioteca System.Linq do dotnet para fazer a somar e a média da lista de valores.
            Console.WriteLine($"A soma dos valores é: {SomarValores(listaDeValores)}");
            Console.WriteLine($"A média dos valores é: {MediaValores(listaDeValores)}");
        }

        static List<Decimal> listaNumeros = new List<decimal>();
       
        static List<decimal> ColetarValores(int quantidadeDeValores)
        {
            
            for (int i = 0; i < quantidadeDeValores; i++)
            {
                Console.Write("Insira numero: ");
                decimal num = decimal.Parse(Console.ReadLine());
                listaNumeros.Add(num);
            }
            return listaNumeros;
        }

        static public decimal SomarValores(List<decimal> listaNumeros)
        {
            Decimal total = 0;

            foreach (decimal valor in listaNumeros)
            {
                total += valor;
                Console.Wr
            }
            return total;
        }

        static public decimal MediaValores(List<decimal> listaNumeros)
        {
            decimal soma = SomarValores(listaNumeros);

            decimal resultado = soma / listaNumeros.Count;

            return resultado;
        }

    }
}

