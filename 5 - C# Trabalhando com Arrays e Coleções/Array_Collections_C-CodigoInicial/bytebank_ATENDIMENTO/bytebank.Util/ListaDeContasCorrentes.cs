using bytebank.Modelos.Conta;

namespace bytebank_Atendimento.bytebank.Util;

internal class ListaDeContasCorrente
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao = 0;

    public ListaDeContasCorrente(int tam = 5)
    {
        _itens = new ContaCorrente[tam];
    }

    public void AdicionarConta(ContaCorrente conta)
    {
        Console.WriteLine($"Adicionando conta na posição {_proximaPosicao}");
        VerificarCapacidade(_proximaPosicao + 1);
        _itens[_proximaPosicao] = conta;
        _proximaPosicao++;

      
    }


    private void VerificarCapacidade(int tamanhoNecessario)
    {
       if(_itens.Length >= tamanhoNecessario)
        {
            return;
        }

        Console.WriteLine("Aumentando a capacidade da lista");

        ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

        for(var i = 0; i  < _itens.Length; i++)
        {
            novoArray[i] = _itens[i];
        }

        _itens = novoArray;
    }

    public void RemoverConta(ContaCorrente conta)
    {
        for(int i =  0; i < _itens.Length; i++)
        {
            if (_itens[i] == conta)
            {

            }
        }
    }

    public ContaCorrente RetornaContaComMaiorSaldo()
    {
        ContaCorrente ContaComMaiorSaldo = null!;
        double saldo = 0;
        
        foreach(ContaCorrente i in _itens)
        {
            if(i.Saldo >= saldo)
            {
                saldo = i.Saldo;   
                ContaComMaiorSaldo = i;
            }
        }

        return ContaComMaiorSaldo!;
    }

    public void ExibeLista()
    {
        for (int i = 0; i < _itens.Length; i++)
        {
            if (_itens[i] != null)
            {
                var conta = _itens[i];
                Console.WriteLine($" Indice[{i}] = Conta:{conta.Conta} - N° da Agência: {conta.Numero_agencia}");
            }
        }
    }
}