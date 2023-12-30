using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_JogarDados.models
{
    public class Pessoa
    {
        public Pessoa(string nome){
            Nome = nome;
        }

        public String Nome { get; set; }
        public int Pontos { get; set; }

         public int RodarDados(){
            if(numeroDeRodadas < 3){
            Random random = new Random();
            int nAleatorio = random.Next(1,10);
            return nAleatorio;
            }else{
                Console.WriteLine("O jogo acabou")
            }
        }
    }
}