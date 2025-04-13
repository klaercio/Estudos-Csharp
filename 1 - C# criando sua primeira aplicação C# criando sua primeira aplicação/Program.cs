// Screen Sound

string mensagem = "Boas vindas ao Screen Sound";
//List<string> bandas = new List<string>();
Dictionary<string,  List<int>> bandas = new Dictionary<string, List<int>>{{"teste", new List<int>{10, 2, 5, 19}}};


MostraMensagem();
ExibirOpcoesDoMenu();

void MostraMensagem() {
    Console.WriteLine(mensagem);
}

void ExibirOpcoesDoMenu() {
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 Para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) {
        case 1: RegistrarBanda();
          break;
        case 2: ListarBandas();
          break;
        case 3: AvaliarBanda();
          break;
        case 4: exibirMedia();
          break;
        case -1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
          break;
        default: Console.WriteLine("opção inválida");
          break;
    }
}


void RegistrarBanda(){
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que desejar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!");
    bandas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandas() {
    foreach(string banda in bandas.Keys)
    {
        Console.WriteLine("Banda:" + banda);
    }

    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda() {
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(!bandas.ContainsKey(nomeDaBanda)) {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.Clear();
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }

    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
    int nota = int.Parse(Console.ReadLine()!);
    bandas[nomeDaBanda].Add(nota);
    Console.WriteLine($"A nota {nota} foi registrado com sucesso para a banda {nomeDaBanda}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void exibirMedia() {
    Console.Write("Digite o nome da banda");
    string banda = Console.ReadLine()!;
    int soma = 0, media;

   if(!bandas.ContainsKey(banda)) {
    Console.WriteLine("Banda não existe");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
   }

    foreach(int nota in bandas[banda]){
       soma += nota;
    }

    media = soma/bandas[banda].Count;

    Console.WriteLine($"a média é {media}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}