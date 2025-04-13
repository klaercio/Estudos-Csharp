namespace Formas.Modelos;

internal class Triangulo : IForma
{
    public Triangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public double Base {get; set;}
    public double Altura {get; set;}

    public double CalculaArea()
    {
        return Base * Altura / 2;    
    }
}