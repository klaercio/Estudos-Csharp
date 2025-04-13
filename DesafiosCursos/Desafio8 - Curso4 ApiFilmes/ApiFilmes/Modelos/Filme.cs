using System.Text.Json.Serialization;

namespace ApiFilmes.Modelos;

internal class Filme {
    [JsonPropertyName("title")]
    public string? Nome {get; set;}
    [JsonPropertyName("year")]
    public string? AnoLancamento {get; set;}
    [JsonPropertyName("rank")]
    public string? Nota {get; set;}


    public void ExibirDetalhes() {
        Console.WriteLine($"Filme: {Nome}");
        Console.WriteLine($"Ano lançamento: {AnoLancamento}");
        Console.WriteLine($"Nota: {Nota}");
        
    }
}