using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _5_RodarDados.model
{
    internal class JogoDeDados
    {
        public int numeroJogadas { get; set; }

        public int JogarDados()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(0, 10);
            return numeroAleatorio;
        }
    }
}
