class Banda {

    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome {get; set;}

    public void AdicionarAlbum(Album album) {
        albuns.Add(album);
    }

    public void ListarAlbuns() {
        foreach(var album in albuns) {
            Console.WriteLine($"Album {album.Nome} - {album.DuracaoTotal} minutos");
        }
    }
}