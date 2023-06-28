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

    Console.WriteLine("\nDigite 1 para registrar uma banda!");
    Console.WriteLine("Digite 2 para listar todas as bandas!");
    Console.WriteLine("Digite 3 para avaliar uma banda!");
    Console.WriteLine("Digite 4 para exibir a nota média de uma banda!");
}

ExibirMenssagemBoasVindas();
ExibirOpcoesDoMenu();