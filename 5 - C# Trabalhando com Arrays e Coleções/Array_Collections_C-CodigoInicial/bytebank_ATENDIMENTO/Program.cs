/*using bytebank.Modelos.Conta;
using bytebank_Atendimento.bytebank.Util;

ContaCorrente[] contasCorrentes = new ContaCorrente[]
{
    new ContaCorrente(874),
    new ContaCorrente(874),
    new ContaCorrente(874)
};

ListaDeContasCorrente lista = new(3);

contasCorrentes[1].Saldo = 1000;

Console.WriteLine(lista[3]);

lista.AdicionarConta(contasCorrentes[0]);
lista.AdicionarConta(contasCorrentes[1]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);

Console.WriteLine(lista.RetornaContaComMaiorSaldo());*/

int[] numeros = new int[5];
int[] pares  = new int[5];
int soma = 0, maior = 0, menor = 0, indice  = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i}° número:");
    numeros[i] = int.Parse(Console.ReadLine()!);
    soma += numeros[i];
    if(numeros[i] % 2 == 0)
    {
        pares[indice] = numeros[i];
        indice++;
    }
}

for (int i = 0;i < numeros.Length;i++)
{
    if(numeros[i] > maior)
    {
        maior = numeros[i];
    }else  if(numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Maior:  {maior}");
Console.WriteLine($"Menor: {menor}");
Console.Write("Pares:  ");
foreach(int i in pares)
{
    Console.Write($"{i}");
}