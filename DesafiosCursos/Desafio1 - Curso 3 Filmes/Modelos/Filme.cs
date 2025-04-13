namespace Alura.Filmes;
class Filme {
    public Filme(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
        artistas = new List<Artista>();
    }

    private List<Artista> artistas;
    public string Titulo {get; set;}
    public int Duracao {get; set;}
    public List<Artista> Artistas {get => artistas;}

    public void AdicionarArtista(Artista artista) {
        if (!artistas.Contains(artista)) {
            artistas.Add(artista);
            artista.AdicionarFilmes(this);
            
            Console.WriteLine($"Artista {artista.Nome} adicionado ao filme {Titulo} com sucesso!!!");
        }
    }
}