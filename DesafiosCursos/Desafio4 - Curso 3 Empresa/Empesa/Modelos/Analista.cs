namespace Empresa.Modelos;

internal class Analista: Funcionario {
    public Analista(string nome, double salario, string especialidade)
    {   
        Nome = nome;
        Salario = salario;
        Especialidade = especialidade;
    }

    public string Especialidade {get; set;}
}