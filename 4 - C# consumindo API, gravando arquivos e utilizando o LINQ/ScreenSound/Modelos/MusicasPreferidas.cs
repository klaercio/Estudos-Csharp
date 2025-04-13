using System.Text.Json;
using ScreenSound.Modelos;

internal class MusicasPreferidas
{

    private List<Musica> listaFavorias;
    public string? Nome { get; set; }
    public IEnumerable<Musica> ListaFavoritas { get => listaFavorias; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        listaFavorias = new();
    }

    public void AdicionarMusica(Musica musica)
    {
        listaFavorias.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essa é a playlist {Nome}:");

        foreach (var musica in ListaFavoritas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaFavoritas,
        });

        string nomeDoArquivo = $"Músicas {Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo foi gerado no caminho {Path.GetFullPath(nomeDoArquivo)}");
    }
}