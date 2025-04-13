using JsonPessoa.Modelos;

namespace JsonPessoa.Filter;

internal class LinqFilter {
    public static void FiltarPorIdade(List<Pessoa> pessoas,int idade) {
        var resultado = pessoas.Where(p => p.Idade == idade).ToList();

        foreach(var pessoa in resultado) {
            pessoa.ExibirDetalhes();
        }
    }
}