using System.Text.Json.Serialization;

namespace ApiCarros.Modelos;

internal class Carro {
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }
    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }
    [JsonPropertyName("motor")]
    public string? Motor { get; set; }
    [JsonPropertyName("transmissao")]
    public string? Transmissao { get; set; }
    [JsonPropertyName("ano")]
    public int Ano {get; set;}

    public void ExibirDetalhes() {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Motor: {Motor}");
        Console.WriteLine($"Transmissão: {Transmissao}");
    }
}