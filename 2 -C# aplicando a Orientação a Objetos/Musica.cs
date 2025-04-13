using System.Collections.Concurrent;

class Musica
{
    public string Nome {get; set;}
    public Banda Artista {get;}
    public int Duracao {get; set;}
    public bool Disponivel {get; set;}
    public Genero GeneroMusica {get; set;}
    public string Descricao 
    { 
        get 
            { 
                return $"A musica {Nome} pertence a banda {Artista}";
            }
    }
    //public string Descricao => $"A musica {Nome} pertence a banda {Artista}" - Essa arrow function funciona da mesma maneira do código de cima e é conhecida como lambda, ela é a maneira mais convencional utiliza quando temos uma propriedade somente com get.

    public Musica(Banda artista, string nome = "sem nome", int duracao = 0, bool disponivel = true)
    {
        this.Nome = nome;
        this.Artista = artista;
        this.Duracao = duracao;
        this.Disponivel = disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponível: {Disponivel}");
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}
