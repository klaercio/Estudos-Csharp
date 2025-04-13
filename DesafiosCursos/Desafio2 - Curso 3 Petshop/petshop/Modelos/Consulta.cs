namespace Petshop.Modelos;

internal class Consulta{
    public Consulta(string titulo, Medico doutor, Pet animal, string diagnostico)
    {
        Titulo = titulo;
        Doutor = doutor;
        Animal = animal;
        Diagnostico = diagnostico;
    }

    public string Titulo {get; set;}
    public Medico Doutor {get; set;}
    public Pet Animal {get; set;}
    public string Diagnostico {get; set;}

    public void MostrarConsulta() {
        Console.WriteLine($"Titulo {Titulo} \nMédico {Doutor.Nome} \nAnimal {Animal.Name} \nDiagnostico {Diagnostico}");
    }
}