using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            MenuExibirDetalhes.ExibirTituloDaOpcao("Registro de bandas");
            Console.Write("\nDigite o nome da banda que deseja adicionar: ");
            string nomeBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeBanda);
            bandasRegistradas.Add(nomeBanda, banda);
            Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            
        }
    }
}
