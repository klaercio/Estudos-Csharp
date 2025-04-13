using Petshop.Modelos;

internal class Pet {
    public Pet(string name, int idade, Dono tutor)
    {   
        Name = name;
        Idade = idade;
        dono = tutor;
    }

    private Dono dono;
    public string Name {get; set;}
    public int Idade {get; set;}
    public Dono Tutor {get => dono;}
}