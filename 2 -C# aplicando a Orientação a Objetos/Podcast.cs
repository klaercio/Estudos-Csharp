class Podcast {
    public Podcast(string host, string nome)
    {
        Host = host;
        this.Nome = nome;
    }

    private List<Episodio> episodios = new List<Episodio>();
    public string Host {get; set;}
    public string Nome {get; set;}
    public int TotalEpisodios {get;}

    public void AdicionarEpisodio(Episodio episodio) {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes() {
        Console.WriteLine($"Podcast {Nome} - Host: {Host}");

        foreach(var episodio in episodios) {
            Console.WriteLine($"Episodio {episodio.Ordem}");
            episodio.mostrarConvidados();
        }
    }
}