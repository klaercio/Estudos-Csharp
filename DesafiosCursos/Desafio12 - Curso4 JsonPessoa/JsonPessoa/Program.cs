using System.Text.Json;
using JsonPessoa.Filter;
using JsonPessoa.Modelos;

/* Pessoa klaercio = new("Klaercio", 24, "klaerciosilva@gmail.com");

string jsonPessoa = File.ReadAllText("Pessoa.json");

var pessoa = JsonSerializer.Deserialize<Pessoa>(jsonPessoa)!;

pessoa.ExibirDetalhes(); */
/* 
Console.WriteLine("Quantas pessoa você quer adicionar?");
int qtdPessoas = int.Parse(Console.ReadLine());
List<Pessoa> pessoas = new();

for (var i = 0; i < qtdPessoas; i++)
{
    Console.WriteLine("Nome");
    string nome = Console.ReadLine()!;
    Console.WriteLine("Idade");
    int idade = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Email");
    string email = Console.ReadLine()!;

    pessoas.Add(new Pessoa(nome, idade, email));
} */

string nomeArquivo = "pessoas.json";
/* string pessoasJson = JsonSerializer.Serialize(pessoas);

File.WriteAllText(nomeArquivo, pessoasJson); */

string arquivoTexto = File.ReadAllText(nomeArquivo);

var listPessoas = JsonSerializer.Deserialize<List<Pessoa>>(arquivoTexto);

LinqFilter.FiltarPorIdade(listPessoas ,220);



/* klaercio.GerarArquivoJson(); */