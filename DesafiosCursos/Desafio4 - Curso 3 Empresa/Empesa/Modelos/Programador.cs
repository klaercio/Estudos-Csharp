namespace Empresa.Modelos;

internal class Programador: Funcionario {
    public string Especialidade {get; set;}

    public Programador (string nome, double salario, string especialidade) {
        this.Nome = nome;
        this.Salario = salario;
        this.Especialidade = especialidade;
    }


    public override void MostraInformações()
    {
        base.MostraInformações();
        Console.WriteLine(Nome);
        Console.WriteLine(Salario);
        Console.WriteLine(Especialidade);
    }
}