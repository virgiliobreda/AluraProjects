using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Podcast
    {
        private List<Episodio> listaDeEpisodios = new List<Episodio>();

        public string Host { get;}
        public string Nome { get;}

        public int TotalEpisodios => listaDeEpisodios.Count;

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            listaDeEpisodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome do podcast: {Nome} Host: {Host}\n");
            foreach (Episodio episodio in listaDeEpisodios.OrderBy(e => e.Ordem)) 
            {
                Console.WriteLine($"{episodio.Resumo}");
            }
            Console.WriteLine($"Total de episodios: {TotalEpisodios}");
        }
    }
}
