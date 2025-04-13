try
{
    Console.WriteLine("Digite um número");
    int a = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite outro número");
    int b = int.Parse(Console.ReadLine()!);
    int resultado = a / b;

    Console.WriteLine(resultado);
}
catch (Exception err)
{
    Console.WriteLine($"Ocorreu o seguinte erro: {err.Message}");
}

