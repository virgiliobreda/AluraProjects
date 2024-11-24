//using ScreenSound;
//Banda queen = new Banda("Queen");
//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false
//};


//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

using ScreenSound;

Episodio ep1 = new(2, 45, "Técnicas de faiclitação");
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

//Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(1,67, "Técnicas de aprendizado");
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
//Console.WriteLine(ep2.Resumo);


Podcast p1 = new Podcast("Paula", "Podcast Especial");
p1.AdicionarEpisodio(ep1);
p1.AdicionarEpisodio(ep2);
p1.ExibirDetalhes();