using System.Text.Json;
using ApiPais.Modelos;

using (HttpClient client = new HttpClient()){

    try 
    {
        string result = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        Console.WriteLine(result);
        var paises = JsonSerializer.Deserialize<List<Pais>>(result)!;

        paises[3].ExibirDetalhes();
    }catch(Exception err)
    {
        Console.WriteLine($"Erro na execução do programa. Erro = {err}");
    }
}