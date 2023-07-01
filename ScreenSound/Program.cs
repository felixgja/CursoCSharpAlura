// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "Bring Me The Horizon", "Bad Omens", "Spiritbox" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Bring Me The Horizon", new List<int> { 10, 8, 9, 10, 6 });
bandasRegistradas.Add("Spiritbox", new List<int> {8, 7, 10, 5 });
bandasRegistradas.Add("Bad Omens", new List<int> { 8, 8, 5, 10, 9 });
bandasRegistradas.Add("Babymetal", new List<int>());

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
            MenuRegistroBanda();
            break;
        case 2:
            MenuListarBandas();
            break;
        case 3:
            MenuAvaliarBanda();
            break;
        case 4:
            MenuExibirMedia();
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

void MenuRegistroBanda()
{
    Console.Clear();
    TituloMenu("Registro de Banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;

    if (VerificarExistenciaBanda(nomeBanda))
    {
        Console.WriteLine("A banda {0} já está registrada em nosso sistema.", nomeBanda);
    }
    else
    {
        bandasRegistradas.Add(nomeBanda, new List<int>());
        Console.WriteLine("A banda {0} foi registrada com sucesso em nosso sistema.", nomeBanda);
    }

    Console.WriteLine("Pressione qualquer tecla para voltar ao menu iniciar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MenuListarBandas()
{
    Console.Clear();
    TituloMenu("Lista de Bandas");
    Console.WriteLine();
    Console.WriteLine("Aqui está a lista com todas as bandas registradas em nosso sistema:");
    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu iniciar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MenuAvaliarBanda()
{
    Console.Clear();
    TituloMenu("Avaliação de Bandas");
    Console.WriteLine();
    Console.Write("Qual o nome da banda que deseja avaliar? ");
    string nomeBanda = Console.ReadLine()!;
    if (VerificarExistenciaBanda(nomeBanda))
    {
        AvaliarBanda(nomeBanda);
    }
    else
    {
        Console.WriteLine("A banda {0} não foi encontrada", nomeBanda);
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu iniciar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MenuExibirMedia()
{
    Console.Clear();
    TituloMenu("Média de Avalições");
    Console.WriteLine();
    Console.Write("Qual banda deseja saber média de avaliações? ");
    var nomeBanda = Console.ReadLine()!;
    if (VerificarExistenciaBanda(nomeBanda))
    {
        CalculaMedia(nomeBanda);
    }
    else
        Console.WriteLine("A banda {0} não foi encontrada.", nomeBanda);
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu iniciar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

bool VerificarExistenciaBanda(string nomeBanda)
{
    foreach (var banda in bandasRegistradas.Keys)
    {
        if (banda.Equals(nomeBanda)) return true;
    }
    return false;
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

void AvaliarBanda(string nomeBanda)
{
    Console.Write("Avalie a {0} com uma nota de 0 à 10: ", nomeBanda);
    int aval;
    do
    {
        aval = int.Parse(Console.ReadLine()!);
        if (!(aval < 0 || aval > 10))
        {
            bandasRegistradas[nomeBanda].Add(aval);
            Console.WriteLine("Avaliação feita com sucesso!");
        }
        else
        {
            Console.Write("Nota inválida, por favor avalie com uma nota entre 0 e 10: ");
        }

    } while (aval < 0 || aval > 10);
}

void CalculaMedia(string nomeBanda)
{
    int qtdeAval = bandasRegistradas[nomeBanda].Count();
    int somaNotas = 0;
    if (qtdeAval < 1)
    {
        Console.WriteLine($"A banda {nomeBanda} não possui avaliações para se calcular a média.");
    }
    else
    {
        foreach (var nota in bandasRegistradas[nomeBanda])
        {
            somaNotas = somaNotas + nota;
        }
        Console.WriteLine($"A Banda {nomeBanda} possui um total de {qtdeAval} avaliações, e possui uma nota média de {somaNotas / qtdeAval}");
    }
}