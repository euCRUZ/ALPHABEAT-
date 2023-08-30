// Alphabeat - 2023
string welcome = "Boas Vindas ao Alphabeat!";

Dictionary<string, List<int>> artistasRegistrados = new Dictionary<string, List<int>>();
artistasRegistrados.Add("MC IG", new List<int> {10, 8, 6});
artistasRegistrados.Add("Travis Scott", new List<int>());

void ExibirLogo()
{
    // text font apply for "Alphabeat"
    Console.WriteLine(@"

░█████╗░██╗░░░░░██████╗░██╗░░██╗░█████╗░██████╗░███████╗░█████╗░████████╗
██╔══██╗██║░░░░░██╔══██╗██║░░██║██╔══██╗██╔══██╗██╔════╝██╔══██╗╚══██╔══╝
███████║██║░░░░░██████╔╝███████║███████║██████╦╝█████╗░░███████║░░░██║░░░
██╔══██║██║░░░░░██╔═══╝░██╔══██║██╔══██║██╔══██╗██╔══╝░░██╔══██║░░░██║░░░
██║░░██║███████╗██║░░░░░██║░░██║██║░░██║██████╦╝███████╗██║░░██║░░░██║░░░
╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░
");
    Console.WriteLine(welcome);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um(a) artista ou grupo musical;");
    Console.WriteLine("Digite 2 para exibir os artistas musicais;");
    Console.WriteLine("Digite 3 para avaliar um(a) artista ou grupo musical;");
    Console.WriteLine("Digite 4 para exibir a média de um(a) artista ou grupo musical;");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaInt)
    {
        case 1:  RegistrarBanda(); break;
        case 2:  MostrarArtistasRegistrados(); break;
        case 3:  AvaliarUmArtista(); break;
        case 4:  MostrarMediaDoArtista(); break;
        case -1: Console.WriteLine("Tchau Tchau! :) "); break;
        default: Console.WriteLine("Opção inválida!"); break;   
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Artistas Musicais");
    Console.Write("\nDigite o nome do(a) artista ou grupo musical que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    artistasRegistrados.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"{nomeDaBanda} foi registrado(a) com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarArtistasRegistrados()
{
    Console.Clear();
    Console.WriteLine("Artistas e/ou Grupos Musicais Registrados\n");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Artista(s) ou Grupo Musical: {listaDasBandas[i]}");
    //}

    foreach (string artistas in artistasRegistrados.Keys)
    {
        Console.WriteLine($"Artista(s) ou Grupo Musical: {artistas}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarUmArtista()
{
    // digitar o nome do artista/grupo musical
    // verificar se o artista/grupo musical existe
    // se existir, pedir para o usuário digitar a nota
    // adicionar a nota na lista de notas do artista/grupo musical
    // se não existir, volta para o menu principal

    Console.Clear();
    Console.WriteLine("Avaliar Artistas e Grupos Musicais");
    Console.Write("\nDigite o nome do(a) artista ou grupo musical que deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        Console.Write($"\nDigite a nota que deseja dar para {nomeDoArtista}: ");
        int nota = int.Parse(Console.ReadLine()!);
        artistasRegistrados[nomeDoArtista].Add(nota);
        Console.WriteLine($"\n{nomeDoArtista} recebeu a nota {nota} com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else  
    {
        Console.WriteLine($"\n{nomeDoArtista} não encontrado(a)!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
    
}

void MostrarMediaDoArtista()
{
    // digitar qual artista/grupo musical o usuário deseja ver a média
    // verificar se o artista/grupo musical existe
    // se existir, calcular a média das notas do artista/grupo musical e exibir na tela o resultado
    // se não existir, volta para o menu principal

    Console.Clear();
    Console.WriteLine("Média das Avaliações de Artistas e Grupos Musicais");
    Console.Write("\nDigite o nome do(a) artista ou grupo musical que deseja ver a média: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    
    {
        if (artistasRegistrados[nomeDoArtista].Count == 0)
        {
            Console.WriteLine($"\n{nomeDoArtista} ainda não recebeu nenhuma avaliação!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }
        else
        {
            double nota = artistasRegistrados[nomeDoArtista].Average();
            Console.WriteLine($"\nA média das avaliações de {nomeDoArtista} é {nota}.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();

            //List<int> notasDosArtistas = artistasRegistrados[nomeDoArtista];
            //Console.WriteLine($"\nA média das avaliações de {nomeDoArtista} é {notasDosArtistas.Average()}.");
            //Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            //Console.ReadKey();
            //Console.Clear();
            //ExibirOpcoesMenu();
        }

    }
    else  
    {
        Console.WriteLine($"\n{nomeDoArtista} não encontrado(a)!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();

Console.WriteLine("Fim do programa!");  