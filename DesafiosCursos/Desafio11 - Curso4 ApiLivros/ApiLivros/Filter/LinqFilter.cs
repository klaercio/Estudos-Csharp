using ApiLivros.Modelos;

namespace ApiLivros.Filter;

internal class LinqFilter {

    public static void FilterAnoPublicação(List<Livro> livros ,int ano) {
        var resultado = livros.Where(l => l.AnoPublicacao >= ano).Distinct().Select(l => (l.Titulo, l.AnoPublicacao)).ToList();
        
        foreach(var livro in resultado) {
            Console.WriteLine($"Livro {livro.Titulo} - Publicado em {livro.AnoPublicacao}");
        }
    }
}