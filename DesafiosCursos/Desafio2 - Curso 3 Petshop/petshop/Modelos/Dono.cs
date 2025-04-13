namespace Petshop.Modelos;

class Dono {

    public Dono (string nome, int idade) {
        Nome = nome;
        Idade = idade;
        animais = new List<Pet>();
    }

    private List<Pet> animais;
    public string Nome {get; set;}
    public int Idade {get; set;}
    public List<Pet> Animais {get => animais;}

    public void AdicionarPet(Pet animal) {
        if (animais.Contains(animal)) {
            animais.Add(animal);
        }
    }

    public void ListarAnimais() {
        foreach (var animal in animais) {
            Console.WriteLine(animal.Name);
        }
    }


}