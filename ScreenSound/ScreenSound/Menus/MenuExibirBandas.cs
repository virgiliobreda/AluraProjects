using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuExibirBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            Menu.ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}
