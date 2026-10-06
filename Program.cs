// Screen Sound 
using static Operacoes.Exercicios;
using static Somar.UmaLista;

string mensagemDeBoasVindas = "Boas vindas  ao Screen Sound";
List<string> listaDasBandas = new List<string>();

void ExibirLogo()
{
    Console.WriteLine(@"
    ╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━━╮╱╱╱╱╱╱╱╱╱╱╭╮
    ┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╱╱┃╭━╮┃╱╱╱╱╱╱╱╱╱╱┃┃
    ┃╰━━┳━━┳━┳━━┳━━┳━╮╱┃╰━━┳━━┳╮╭┳━╮╭━╯┃
    ╰━━╮┃╭━┫╭┫┃━┫┃━┫╭╮╮╰━━╮┃╭╮┃┃┃┃╭╮┫╭╮┃
    ┃╰━╯┃╰━┫┃┃┃━┫┃━┫┃┃┃┃╰━╯┃╰╯┃╰╯┃┃┃┃╰╯┃
    ╰━━━┻━━┻╯╰━━┻━━┻╯╰╯╰━━━┻━━┻━━┻╯╰┻━━╯
    ");

    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para fazer continhas");
    Console.WriteLine("Digite 6 para somar uma lista");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("Digite a sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
            break;
        case 4:
            Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
            break;
        case 5:
            ExecOps();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
        case 6:
            ExecSomaLista();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
        case -1:
            Console.WriteLine($"Tchau tchau =)");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**********************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!; 
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucessso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("\n****************************");
    Console.WriteLine("Exibindo bandas registradas");
    Console.WriteLine("****************************\n");
    
    // for(int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach(string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    // listaDasBandas.ForEach(banda => Console.WriteLine($"Banda: {banda}"));

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();