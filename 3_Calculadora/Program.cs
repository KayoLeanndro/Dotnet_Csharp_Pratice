using _3_Calculadora.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo a Calculadora!\n");

Calculadora c = new Calculadora();
string opcao = string.Empty;
bool exibirMenuCalculadora = true;


while (exibirMenuCalculadora)
{
    Console.Clear();
    Console.WriteLine("Que conta você deseja realizar? :");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Resto de divisão ");
    Console.WriteLine("6 - Potencia");
    Console.WriteLine("0 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
           
            break;

        case "2":
            
            break;

        case "3":
           
            break;

        case "4":
           
            break;

        case "5":

            break;
        
        case "6":

            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

