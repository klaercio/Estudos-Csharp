using System.Globalization;
using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica {

    private Dictionary<int, string> tonalidade = new () {
        {0, "C"},
        {1, "C#"},
        {2, "D"},
        {3, "D#"},
        {4, "E"},
        {5, "F"},
    };
    [JsonPropertyName("key")]
    public int KeyIndex {get; set;}
    [JsonPropertyName("song")]
    public string? Nome {get; set;}
    [JsonPropertyName("artist")]
    public string? Artista {get; set;}
    [JsonPropertyName("duration_ms")]
    public int Duracao {get; set;}
    [JsonPropertyName("genre")]
    public string? Genero {get; set;}
    [JsonPropertyName("year")]
    public string? AnoLancamento {get; set;}
    public string Tonalidade{get => tonalidade.ContainsKey(KeyIndex)? tonalidade[KeyIndex]: "tonalidade desconhecida";}

    public void ExibirDetalhesDaMusica() {
        Console.WriteLine($"Artista : {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao/1000}s");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Ano lançamento: {AnoLancamento}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
        Console.WriteLine($"key: {KeyIndex}");
    }
}