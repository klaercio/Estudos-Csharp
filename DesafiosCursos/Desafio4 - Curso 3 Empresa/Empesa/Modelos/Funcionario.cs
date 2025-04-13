namespace Empresa.Modelos;

internal class Funcionario {
    public string Nome {get; set;}
    public double Salario {get; set;}


    public virtual void MostraInformações() {
        Console.WriteLine("Essa são as informações o funcionário");
    }
}