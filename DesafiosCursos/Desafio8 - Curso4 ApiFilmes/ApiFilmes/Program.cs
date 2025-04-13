using System.Text.Json;
using ApiFilmes.Modelos;

using (HttpClient client = new HttpClient()) {

    try {
        string result = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

        var filmes = JsonSerializer.Deserialize<List<Filme>>(result)!;

        filmes[0].ExibirDetalhes();
        
    }catch (Exception err)
     {
        Console.WriteLine($"Erro: {err}");
     }
}