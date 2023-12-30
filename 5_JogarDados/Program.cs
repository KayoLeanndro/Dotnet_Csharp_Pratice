using _5_JogarDados.models;
JogoDeDados jgDados = new JogoDeDados();
Pessoa p1 = new Pessoa("Julia");
Pessoa p2 = new Pessoa("Marcos");

for(int i = 0; i < 3; i++)
{
    if(p1.RodarDados() > p2.RodarDados())
    {
        Console.WriteLine($"{p1.Nome} tirou o numero")
    }
}