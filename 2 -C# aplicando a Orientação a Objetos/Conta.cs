class Conta {
    public string NumeroConta {get; set;}
    public string Titular {get; set;}
    public double Saldo {get; set;}
    private string Senha {get; set;}

    public Conta(string conta, string titular, string senha ,double saldo = 0) {
        this.NumeroConta = conta;
        this.Titular = titular;
        this.Saldo = saldo;
        this.Senha = senha;
    }

    public void MostrarDadosConta() {
        Console.WriteLine($"Conta {NumeroConta}, Titula {Titular}, Saldo {Saldo}");
    }
}