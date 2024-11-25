using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            Menu.ExibirTituloDaOpcao("Registro de álbums");
            Console.Write("\nDigite a banda cujo álbum deseja registrar: ");
            string nomeBanda = Console.ReadLine()!;


            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeBanda];
                banda.AdicionarAlbum(new Album(tituloAlbum));
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
}
