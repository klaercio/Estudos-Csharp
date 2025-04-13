class Episodio {
    public Episodio(int duracao, int ordem, string resumo, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Resumo = resumo;
        Titulo = titulo;
    }

    private List<string> convidados = new List<string>();
    public int Duracao {get; set;}
    public int Ordem {get; set;}
    public string Resumo {get; set;}
    public string Titulo {get; set;}

    public void AdicionarConvidado(string nome) {
        convidados.Add(nome);
    }

    public void mostrarConvidados() {
        foreach(var nome in convidados) {
            Console.WriteLine($"Convidado: {nome}");
        }
    }
}