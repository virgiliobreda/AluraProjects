using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models;

internal class Banda : IAvaliavel
{
    public  List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new();
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public string Nome { get; }

    public Banda(string nome)
    {
        Nome = nome;
    }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");   
        }
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}

