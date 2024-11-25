namespace ScreenSound.Models;
internal class Album : IAvaliavel
{
    public List<Musica> listaDeMusicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    public string Nome { get;  }
    public int DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

    public double Media 
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(n => n.Nota);
        }
    }

    public Album(string nome)
    {
        Nome = nome;
    }


    public void AdicionarMusica(Musica musica)
    {
        listaDeMusicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do álbum {Nome}\n");
        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine($"Musica: " + musica.Nome);
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você prescisa de {DuracaoTotal} segundos\n");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}