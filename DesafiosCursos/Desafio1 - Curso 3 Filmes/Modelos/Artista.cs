namespace Alura.Filmes;
using Alura.Filmes;

class Artista {
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        filmesList = new List<Filme>();
    }

    private List<Filme> filmesList;
    public string Nome {get; set;}
    public int Idade {get; set;}
    public List<Filme> Filmes {get => filmesList;}

    public void AdicionarFilmes(Filme filme) {
        if(!Filmes.Contains(filme)) {
            filmesList.Add(filme);
            filme.AdicionarArtista(this);
            Console.WriteLine($"Filme {filme.Titulo} adicionado ao Artista {Nome} com sucesso!!!");
        }
    }
}