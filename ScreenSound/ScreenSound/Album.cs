public class Album
{
    private List<Musica> listaDeMusicas = new List<Musica>();

    public string Nome { get;  }
    public int DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

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
}