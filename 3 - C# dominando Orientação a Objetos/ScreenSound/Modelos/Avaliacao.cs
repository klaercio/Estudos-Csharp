namespace ScreenSound.Modelos;

internal class Avaliacao {
    public Avaliacao(int nota) {
        Nota = nota;
    }
    public int Nota {get;}

    public static Avaliacao Parse(string texto) {
        int nota = int.Parse(texto);

        if (nota > 10) {
            nota = 10;
            Console.WriteLine($"Babaca kkkk a nota foi arredonada pra {nota}");
        } else if (nota < 0) {
            nota = 0;
            Console.WriteLine($"Babaca kkkk a nota foi arredondada pra {nota}");
        }
        return new Avaliacao(nota);
    }
}