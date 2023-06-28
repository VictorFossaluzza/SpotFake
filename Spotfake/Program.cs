// Spotfake
string msgDeBoasVindas = "Boas vindas ao SpotFake";

void ExibirMenssagemBoasVindas()
{
    Console.WriteLine(@"
                        ░██████╗██████╗░░█████╗░████████╗███████╗░█████╗░██╗░░██╗███████╗
                        ██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██║░██╔╝██╔════╝
                        ╚█████╗░██████╔╝██║░░██║░░░██║░░░█████╗░░███████║█████═╝░█████╗░░
                        ░╚═══██╗██╔═══╝░██║░░██║░░░██║░░░██╔══╝░░██╔══██║██╔═██╗░██╔══╝░░
                        ██████╔╝██║░░░░░╚█████╔╝░░░██║░░░██║░░░░░██║░░██║██║░╚██╗███████╗
                        ╚═════╝░╚═╝░░░░░░╚════╝░░░░╚═╝░░░╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝
    ");
    Console.WriteLine(msgDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\n");
    Console.WriteLine("Digite 1 para registrar uma banda!");
    Console.WriteLine("Digite 2 para listar todas as bandas!");
    Console.WriteLine("Digite 3 para avaliar uma banda!");
    Console.WriteLine("Digite 4 para exibir a nota média de uma banda!");
    Console.WriteLine("Digite 0 para sair");

    Console.WriteLine("\n");
    Console.Write("Digite sua opção:");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if(opcaoEscolhida == 1)
    {
        Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
    }
}

ExibirMenssagemBoasVindas();
ExibirOpcoesDoMenu();