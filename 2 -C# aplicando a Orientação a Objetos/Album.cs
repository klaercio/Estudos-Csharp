class Album {

    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome {get; set;}
    public int AnoLancamento {get; set;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    
    public void AdicionarMusica(Musica musica) {
        musicas.Add(musica);
    } 

    public void ExibirMusicas() {
        foreach (var musica in musicas) {
            Console.WriteLine($"Musica {musica.Nome}");
        }

        Console.WriteLine($"Duração total do álbum é {DuracaoTotal}");
    }
}