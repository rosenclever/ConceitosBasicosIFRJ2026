/*
 * Copie o código do projeto Revisao e modifique a 
 * estrutura if por switch.
 * Modifique o "do... while" por "while"
 * Acrescente ações para cada valor do dado entre
 * 1 e 10
 * Use sua imaginação e criatividade
 */

// See https://aka.ms/new-console-template for more information
int acao;
do
{
    Console.WriteLine("Nesse instante, surge das nebulosas profundezas do fim do mundo\n um ser horrendo, com 10 cabeças e soprando labaredas de fogo sem fim...");
    Console.WriteLine("Jogue o D10 para ação do herói (0 sai):");
    acao = Convert.ToInt32(Console.ReadLine());
    switch (acao)
    {
        case 0:
            break;
        case 1:
            Console.WriteLine("Você tropeçou e caiu, o monstro te encontrou e você foi derrotado...");
            break;
        case 2:
            Console.WriteLine("Você tentou atacar o monstro, mas errou feio e ficou exposto...");
            break;
        case 3:
            Console.WriteLine("O monstro lançou uma labareda de fogo em sua direção, causando queimaduras graves...");
            break;
        case 4:
            Console.WriteLine("Você tentou se esconder, mas o monstro te encontrou e te atacou...");
            break;
        case 5:
            Console.WriteLine("Você tentou fugir, mas o monstro te alcançou e te feriu...");
            break;
        case 6:
            Console.WriteLine("Você conseguiu se esconder,e o monstro foi para o outro lado...");
            break;
        case 7:
            Console.WriteLine("Você se escondeu tão bem que o monstro não te encontrou, mas ele destruiu tudo ao redor...");
            break;
        case 8:
            Console.WriteLine("Você coneguiu atacar o monstro e ele ficou atordoado...");
            break;
        case 9:
            Console.WriteLine("Você conseguiu atacar o monstro e ele ficou gravemente ferido...");
            break;
        case 10:
            Console.WriteLine("Você conseguiu atacar o monstro e ele foi derrotado!");
            acao = 0; 
            break;
        default:
            Console.WriteLine("Opção inválida! Informe uma ação de 0 a 10");
            break;
    }
    
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
} while (acao != 0);
Console.WriteLine("GAME OVER!");