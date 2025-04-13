using Formas.Modelos;

IForma triangulo = new Triangulo(10, 10);
IForma ciruculo =  new Circulo(5);

Console.WriteLine(ciruculo.CalculaArea());
Console.WriteLine(triangulo.CalculaArea());
