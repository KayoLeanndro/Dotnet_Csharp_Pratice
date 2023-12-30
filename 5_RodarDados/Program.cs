using _5_RodarDados.model;

internal class Program
{
    private static void Main(string[] args)
    {
      JogoDeDados jogo = new JogoDeDados();
        Pessoa p1 = new Pessoa("Larissa",19);
        Pessoa p2 = new Pessoa("Emanuel",20);

        do
        {
            Console.WriteLine("Você quer jogar o dado");
            Console.WriteLine("1[SIM]");
            Console.WriteLine("2[NÃO]");
            int resposta = int.Parse(Console.ReadLine());

            if (jogo.numeroJogadas < 3)
            {
                switch(resposta)
                {
                    case 1:
                        for(int i = 0; i < 3; i++)
                        {
                            int nAleatorio1 = jogo.JogarDados();
                            int nAleatorio2 = jogo.JogarDados();
                            p1.Numeros.Add(nAleatorio1);
                            p2.Numeros.Add(nAleatorio2);

                            if (p1.Numeros[i] > p2.Numeros[i])
                            {
                                Console.WriteLine($"{p1.Nome} tirou {p1.Numeros[i]}, e {p2.Nome} tirou {p2.Numeros[i]}");
                                Console.WriteLine($"Vencedor: {p1.Nome}\n");
                                p1.Vitorias++;
                            }
                            else if(p1.Numeros[i] < p2.Numeros[i])
                            {
                                Console.WriteLine($"{p1.Nome} tirou {p1.Numeros[i]}, e {p2.Nome} tirou {p2.Numeros[i]}");
                                Console.WriteLine($"Vencedor: {p2.Nome}\n");
                                p2.Vitorias++;
                            }
                            else
                            {
                                Console.WriteLine($"{p1.Nome} tirou {p1.Numeros[i]}, e {p2.Nome} tirou {p2.Numeros[i]}");
                                Console.WriteLine("Empate\n");
                            }
                        }
                        if(p1.Vitorias > p2.Vitorias)
                        {
                            Console.WriteLine($"{p1.Nome} foi o vencedor");
                        }
                        else
                        {
                            Console.WriteLine($"{p2.Nome} foi o vencedor");
                        }
                        break;
                        case 2:
                            Console.WriteLine("Jogo encerrado!");
                        break;
                    default:
                        Console.WriteLine("Digite um numero valido!");
                        break;
                }
                jogo.numeroJogadas++;
            }
        } while (true);
    }
}