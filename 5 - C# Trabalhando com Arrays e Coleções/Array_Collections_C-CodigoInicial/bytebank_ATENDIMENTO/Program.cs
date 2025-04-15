using bytebank.Modelos.Conta;
using bytebank_Atendimento.bytebank.Util;


#region Teste

ContaCorrente[] contasCorrentes = new ContaCorrente[]
{
    new ContaCorrente(874),
    new ContaCorrente(874),
    new ContaCorrente(874)
};

ListaDeContasCorrente lista = new(3);

contasCorrentes[1].Saldo = 1000;

lista.AdicionarConta(contasCorrentes[0]);
lista.AdicionarConta(contasCorrentes[1]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);
lista.AdicionarConta(contasCorrentes[2]);

Console.WriteLine(lista.RetornaContaComMaiorSaldo());

#endregion

void AtendimentoCliente()
 {  
    char opcao = '0';
    while(opcao != '6') 
    {
        Console.Clear();
    }
 }