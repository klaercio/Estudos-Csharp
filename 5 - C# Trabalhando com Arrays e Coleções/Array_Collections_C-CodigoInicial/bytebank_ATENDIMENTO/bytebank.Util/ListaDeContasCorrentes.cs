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

    public void AdicionarConta(ContaCorrente conta) {
        
    }
}