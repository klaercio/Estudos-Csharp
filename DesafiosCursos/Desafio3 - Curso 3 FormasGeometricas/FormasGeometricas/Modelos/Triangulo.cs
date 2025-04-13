namespace Formas.Modelos;

internal class Triangulo : FormaGeometrica{
    public int Base {get; set;}
    public int Altura {get; set;}

    public override void calculaArea()
    {
        base.calculaArea();
        int area = (Base * Altura)/2;

        Console.WriteLine(area);
    }


}