// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int numero = 42;
int numero2 = 22;
int soma = numero + numero2++;
Console.WriteLine($"A soma de {numero} com {numero2} é {soma}");
Console.WriteLine("A soma de " + numero + " com " + numero2 + " é " + soma);

if(numero%2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar!");
}

