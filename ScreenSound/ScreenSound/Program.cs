// Screen Sound

using Microsoft.Win32;
using System.Runtime.Serialization;
using ScreenSound.Models;
using ScreenSound.Menus;



Banda ira = new Banda("Ira");
Banda beatles = new Banda("The Beatles");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuExibirBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

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

void ExibirFuncoesDoMenu()
{
    ExibirLogoScreenSound();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhida];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhida > 0) ExibirFuncoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

}

ExibirFuncoesDoMenu();
