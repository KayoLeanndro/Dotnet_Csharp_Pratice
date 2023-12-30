using _3_Calculadora.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem-vindo à Calculadora!\n");

Calculadora c = new Calculadora();
string opcao = string.Empty;
bool exibirMenuCalculadora = true;
int n1, n2;

while (exibirMenuCalculadora)
{
    Console.WriteLine("Que conta você deseja realizar? :");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Resto de divisão ");
    Console.WriteLine("6 - Potencia");
    Console.WriteLine("0 - Encerrar");
    

    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado de {n1} + {n2} : {c.Somar(n1, n2)}");
            break;

        case "2":
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado de {n1} - {n2} : {c.Subtrair(n1, n2)}");
            break;

        case "3":
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado de {n1} * {n2} : {c.Multiplicar(n1, n2)}");
            break;

        case "4":
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado de {n1} / {n2} : {c.Dividir(n1, n2)}");
            break;

        case "5":
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resto da divisão de {n1} por {n2} : {c.RestoDivisao(n1, n2)}");
            break;

        case "6":
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado de {n1} elevado à potência {n2} : {c.Potenciacao(n1, n2)}");
            break;

        case "0":
            exibirMenuCalculadora = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");