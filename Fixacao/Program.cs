double numerador, denominador, resultado;
Console.WriteLine("Informe o numerador: ");
try
{
    numerador = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe o denominador: ");
    denominador = Convert.ToDouble(Console.ReadLine());
    resultado = numerador / denominador;
    Console.WriteLine("{0} / {1} = {2:F2}", numerador, denominador, resultado);
}
catch(FormatException)
{
    Console.WriteLine("Informe apenas números!");
}
catch (Exception e)
{
    Console.WriteLine(e.StackTrace);
}
finally
{
    Console.WriteLine("Fim do bloco de tratamento de erro.");
}
Console.WriteLine("********** FIM DO PROGRAMA ***********");
Console.Read();

/*
 * CRIE UM NOVO PROJETO CHAMADO JOGO_ADIVINHACAO QUE DEVERÁ CONTER UM PROGRAMA
 * QUE SORTEIE UM NÚMERO ENTRE 0 E 100 E SOLICITE A OUSUÁRIO TENTAR ADIVINHAR O 
 * NÚMERO SORTEADO EM ATÉ 10 TENTATIVAS.
 * REALIZE O TRATAMENTO DE ERROS ADEQUADO PARA AS ENTRADAS DO USUÁRIO
 * A APLICAÇÃO DEVERÁ TER UM MENU DE OPÇÕES QUE FORNEÇA AS ALTERNATIVAS:
 * 1) NOVO JOGO
 * 2) RECORD
 * 3) SAIR
 */

