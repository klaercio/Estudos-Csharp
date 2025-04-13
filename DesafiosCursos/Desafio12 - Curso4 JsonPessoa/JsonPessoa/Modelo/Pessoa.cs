using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonPessoa.Modelos;

internal class Pessoa {
    [JsonPropertyName("nome")]
    public string Nome {get; set;}
    [JsonPropertyName("idade")]
    public int Idade {get; set;}
    [JsonPropertyName("email")]
    public string Email {get; set;}

    public Pessoa(string nome, int idade, string email) {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public void GerarArquivoJson() {
        string json = JsonSerializer.Serialize(new {
            nome = Nome,
            idade = Idade,
            email = Email,
        });

        string nomeArquivo = "Pessoa.Json";

        File.WriteAllText(nomeArquivo, json);
    }

    public void ExibirDetalhes() {
        Console.WriteLine($"Nome = {Nome}\nIdade = {Idade}\nEmail = {Email}");
    }
}