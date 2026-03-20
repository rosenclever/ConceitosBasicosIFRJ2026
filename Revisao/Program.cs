// See https://aka.ms/new-console-template for more information
int acao=0;
do
{ 
    Console.WriteLine("Nesse instante, surge das nebulosas profundezas do fim do mundo\n um ser horrendo, com 10 cabeças e soprando labaredas de fogo sem fim...");
    Console.WriteLine("Jogue o D10 para ação do herói (0 sai):");
    try
    {
        acao = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida! Por favor, informe um número entre 0 e 10.");
        continue; 
    }
    if (acao == 0)
    {
        break;
    }
    else if (acao <= 3)
    {
        Console.WriteLine("O herói foi mortalmente ferido... ;-(");
    }
    else if (acao <= 6)
    {
        Console.WriteLine("O herói se feriu bastante, mas conseguiu se esconder a tempo...");
    }
    else
    {
        Console.WriteLine("Nosso herói se escondeu sem nenhum arranhão...");
    }
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
}while(acao != 0);
