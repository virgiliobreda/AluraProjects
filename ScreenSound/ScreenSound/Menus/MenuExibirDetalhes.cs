using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
   
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média de notas para a banda {nomeDaBanda} é {banda.Media}\n");
            Console.WriteLine("Discografia: ");
            foreach (Album album in banda.albums)
            {
                Console.WriteLine($"\n{album.Nome} -> {album.Media}");
            }
        }
        else
        {
            Console.WriteLine("\nBanda não encotrada");

        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
