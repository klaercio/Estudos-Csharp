class Produto {
    
    private double preco;
    private int estoque;
    public string Nome {get; set;}
    public string Marca {get; set;}
    public double Preco 
        {
            get => preco; 
            set {
                preco = value > 0 ? value :  10;
            }
        }
    public int Estoque 
        {
            get => estoque;
            set {
                estoque = value > 0? value : 0;
            }
        }
    public string Descricao => $"Nome produto {Nome}, Marca {Marca}, Preço {Preco}, Estoque {Estoque}";

}