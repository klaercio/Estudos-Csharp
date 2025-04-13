namespace ScreenSound.Filtros;
using ScreenSound.Modelos;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"Genero: {genero}");
        }
    }

    public static void ExibirArtistasOrdemAlfabetica(IEnumerable<Musica> musicas)
    {
        var artistas = musicas.Select(a => a.Nome).Distinct().OrderBy(x => x).ToList();

        foreach (var artista in artistas)
        {
            Console.WriteLine($"Artista: {artista}");
        }
    }

    public static void ExibirArtistaPorGeneroMusical(IEnumerable<Musica> musicas, string genero)
    {
        var artistas = musicas.Where(a => a.Genero!.Contains(genero)).Select(a => (a.Artista, a.Genero)).Distinct();

        foreach (var artista in artistas)
        {
            Console.WriteLine($"Artista: {artista.Artista} \nGenero: {artista.Genero}");
        }
    }

    public static void ExibirMusicasPorArtista(IEnumerable<Musica> musicas, string artista)
    {
        var artistas = musicas.Where(m => m.Artista!.Contains(artista)).Select(a => (a.Artista, a.Nome)).Distinct();

        foreach (var a in artistas)
        {
            Console.WriteLine($"Música: {a.Nome} - Artista {a.Artista}");
        }
    }

    public static void FiltrarMusicasPorAno(IEnumerable<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas.Where(m => m.AnoLancamento!.Equals(ano.ToString())).Distinct().Select(m => (m.Nome, m.AnoLancamento)).OrderBy(m => m.Nome).ToList();

        foreach (var musica in musicasPorAno)
        {
            Console.WriteLine($"Música {musica.Nome} lançada em {musica.AnoLancamento}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(IEnumerable<Musica> musicas, int tonalidade) {
        var musicasFiltradas = musicas.Where(m => m.KeyIndex == tonalidade).Distinct().Select( m => (m.Nome, m.KeyIndex));

        foreach(var musica in musicasFiltradas) {
            Console.WriteLine($"Nome: {musica.Nome} - Tonalidade {musica.KeyIndex}");
        }
    }
}