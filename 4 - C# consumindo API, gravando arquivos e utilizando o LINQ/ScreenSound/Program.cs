using System.Text.Json;
using ScreenSound.Filtros;
using ScreenSound.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        /*LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); */
        /*LinqFilter.ExibirArtistasOrdemAlfabetica(musicas);*/
        /*LinqFilter.ExibirArtistaPorGeneroMusical(musicas, "pop"); */
        /*LinqFilter.ExibirMusicasPorArtista(musicas, "Lady"); */
        /*LinqFilter.FiltrarMusicasPorAno(musicas, 2004); */
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, 2);

        /* MusicasPreferidas playlist = new("Favoritas");

        playlist.AdicionarMusica(musicas[0]);
        playlist.AdicionarMusica(musicas[2]);
        playlist.AdicionarMusica(musicas[3]);
        playlist.AdicionarMusica(musicas[25]);
        playlist.AdicionarMusica(musicas[40]);

        playlist.ExibirMusicasFavoritas();

        playlist.GerarArquivoJson(); */

       /*  Console.WriteLine(response); */

        /* foreach(var musica in musicas) {
            musica.ExibirDetalhesDaMusica();
        } */

    }
    catch(Exception err)
    {
        Console.WriteLine($"Temos o seguinte erro: {err.Message}");
    }

    
}