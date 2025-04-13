using System.Text.Json.Serialization;

namespace ApiLivros.Modelos;

internal class Livro {
    [JsonPropertyName("titulo")]
    public string? Titulo{get; set;}
    [JsonPropertyName("autor")]
    public string? Autor {get; set;}
    [JsonPropertyName("ano_publicacao")]
    public int AnoPublicacao {get; set;}
    [JsonPropertyName("genero")]
    public string? Genero {get; set;}
    [JsonPropertyName("paginas")]
    public int Paginas {get; set;}
    [JsonPropertyName("editora")]
    public string? Editora {get; set;}

    public void ExibirDetalhes() {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano Publicacao: {AnoPublicacao}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Paginas: {Paginas}");
        Console.WriteLine($"Editora: {Editora}");
    }
}