namespace Petshop.Modelos;

internal class Medico {
    public Medico(string nome, string crm)
    {
        Nome = nome;
        Crm = crm;
    }

    public string Nome {get; set;}
    public string Crm {get; set;}
}