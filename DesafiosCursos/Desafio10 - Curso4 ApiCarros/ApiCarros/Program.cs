using System.Text.Json;
using ApiCarros.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string result = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(result);
        carros?[2].ExibirDetalhes();
    }
    catch (Exception err)
    {
        Console.WriteLine($"Ocorreu o seguinte erro {err.Message}");
    }
}