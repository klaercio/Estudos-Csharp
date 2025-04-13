using System.Text.Json;
using ApiLivros.Filter;
using ApiLivros.Modelos;

using (HttpClient client = new HttpClient()) {
    try {
        string result = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(result)!;

        LinqFilter.FilterAnoPublicação(livros, 1960);
    }catch(Exception err) 
    {
        Console.WriteLine($"Ocorreu o seguinte erro: {err.Message}");
    }
}