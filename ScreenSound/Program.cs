// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "Bring Me The Horizon", "Bad Omens", "Spiritbox" };

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirOpcoesDoMenu();

void RegistrarBanda()
{
    Console.Clear();
    TituloMenu("Registro de Banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;

    if (VerificarRegistrosBandas(nomeBanda))
    {
        Console.WriteLine("A banda {0} já está registrada em nosso sistema.", nomeBanda);
    }
    else
    {
        listaDasBandas.Add(nomeBanda);
        Console.WriteLine("A banda {0} foi registrada com sucesso em nosso sistema.", nomeBanda);
    }

    Console.WriteLine("Pressione qualquer tecla para voltar ao menu iniciar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

bool VerificarRegistrosBandas(string nomeBanda)
{
    foreach (var banda in listaDasBandas)
    {
        if (banda.Equals(nomeBanda)) return true;
    }
    return false;
}

void ListarBandas()
{
    Console.Clear();
    TituloMenu("Lista de Bandas");
    Console.WriteLine();
    Console.WriteLine("Aqui está a lista com todas as bandas registradas em nosso sistema:");
    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"{i+1}ª - {listaDasBandas[i]}");
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu iniciar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void TituloMenu(string tituloMenu)
{
    int qtdeCaracter = tituloMenu.Length;
    for (int i = 0;i < qtdeCaracter;i++)
    {
        if (i == qtdeCaracter-1)
            Console.WriteLine("*");
        else 
            Console.Write("*");

    }
    Console.WriteLine(tituloMenu);
    for (int i = 0; i < qtdeCaracter; i++)
    {
        if (i == qtdeCaracter - 1)
            Console.WriteLine("*");
        else
            Console.Write("*");
    }

}