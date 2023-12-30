using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_RodarDados.model
{
    internal class Pessoa
    {
        public Pessoa(String nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Numeros = new List<int>();
        }

        public String Nome { get; set; }
        public int Idade { get; set; }

        public List<int> Numeros { get; }

        public int Vitorias;

    }
}
