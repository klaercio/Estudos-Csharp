class Carro {
    private int ano;
    public string modelo{get; set;}
    public string Fabricante{get; set;}
    public int Ano{get => ano; 
        set
        {
            if (value < 1960 || value > 2023) 
                Console.WriteLine("Ano invalido, por favor inserir um valor entre 1960 e 2023");
            else 
                ano = value;
        }}
    public string Cor {get; set;}
    private int velocidade = 0;

    public void Acelerar(int km) {
        int velocidadeSomada = this.velocidade + km;
        Console.WriteLine($"Velocidade aumentada para  = {velocidadeSomada}");
    }

    public void Frear() {
        Console.WriteLine("Frear");
    }

    public void Buzinar() {
        Console.WriteLine("Bi Biiii");
    }
}