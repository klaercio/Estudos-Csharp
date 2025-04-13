namespace Formas.Modelos;

internal class Circulo : IForma
{
    public Circulo(double raio)
    {
        Raio = raio;
    }

    double Raio {get; set;}

    public double CalculaArea()
    {       
        return 3.14 * Math.Pow(Raio, 2);
    }
}