/* Album albumQueen = new Album();
albumQueen.Nome = "A Night at the opera";

Banda queen = new Banda();

Musica musica1 = new Musica(queen, "Love of my life", 350);
Musica musica2 = new Musica(queen, "Bohemian Rhapsody", 150);

Genero rock = new Genero("Rock");

musica1.GeneroMusica = rock;

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

albumQueen.ExibirMusicas();


queen.AdicionarAlbum(albumQueen);

queen.ListarAlbuns();

 */

 Podcast podpah = new Podcast("www.podpah.com", "PodPah");


Episodio episodio1 = new Episodio(30, 1, "primeiro episodio", "1 episodio");
episodio1.AdicionarConvidado("Pedro raul");
episodio1.AdicionarConvidado("Pedro raul2");
episodio1.AdicionarConvidado("Pedro raul3");

Episodio episodio2 = new Episodio(30, 2, "segundo episodio", "2 episodio");
episodio2.AdicionarConvidado("Pedro raul4");
episodio2.AdicionarConvidado("Pedro raul5");
episodio2.AdicionarConvidado("Pedro raul6");

Episodio episodio3 = new Episodio(30, 3, "terceiro episodio", "3 episodio");
episodio3.AdicionarConvidado("Pedro rau7");
episodio3.AdicionarConvidado("Pedro raul8");
episodio3.AdicionarConvidado("Pedro raul9");

podpah.AdicionarEpisodio(episodio1);
podpah.AdicionarEpisodio(episodio2);
podpah.AdicionarEpisodio(episodio3);

podpah.ExibirDetalhes();
