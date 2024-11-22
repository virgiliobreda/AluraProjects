// Screen Sound

using Microsoft.Win32;
using System.Runtime.Serialization;

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogoScreenSound()
{
    Console.WriteLine(@"


 ██████╗ █████╗░██████╗ ███████╗███████╗███╗  ██╗   ██████╗ █████╗ ██╗   ██╗███╗  ██╗██████╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗ ██║  ██╔════╝██╔══██╗██║   ██║████╗ ██║██╔══██╗
╚█████╗ ██║  ╚═╝██████╔╝█████╗  █████╗  ██╔██╗██║  ╚█████╗ ██║  ██║██║   ██║██╔██╗██║██║  ██║
 ╚═══██╗██║  ██╗██╔══██╗██╔══╝  ██╔══╝  ██║╚████║   ╚═══██╗██║  ██║██║   ██║██║╚████║██║  ██║
██████╔╝╚█████╔╝██║  ██║███████╗███████╗██║ ╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║ ╚███║██████╔╝
╚═════╝  ╚════╝ ╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚══╝  ╚═════╝  ╚════╝  ╚═════╝ ╚═╝  ╚══╝╚═════╝

");

}

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("Boas vindas ao Screen Sound\n");
}

void ExibirFuncoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            CalcularMedia();
            break;
        case -1:
            Console.WriteLine($"\nTchau Tchau :)");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("\nDigite o nome da banda que deseja adicionar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogoScreenSound();
    ExibirFuncoesDoMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Thread.Sleep(4000);
    Console.Clear();
    ExibirLogoScreenSound();
    ExibirFuncoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
    Console.WriteLine();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliação de banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota a {nomeDaBanda} merece?: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota } foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear() ;
        ExibirLogoScreenSound();
        ExibirFuncoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!\n");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogoScreenSound();
        ExibirFuncoesDoMenu();
    }
}


void CalcularMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Média de banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média de notas para a banda {nomeDaBanda} é {notasDaBanda.Average()}");;
    }
    else 
    {
        Console.WriteLine("\nBanda não encotrada");
            
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogoScreenSound();
    ExibirFuncoesDoMenu();
}



ExibirLogoScreenSound();
ExibirMensagemDeBoasVindas();
ExibirFuncoesDoMenu();

