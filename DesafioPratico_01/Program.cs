namespace DesafioPratico_01;

class Program
{
    static void Main()
    {
        Exercicio04();
    }

    static void Exercicio01()
    {
        Console.WriteLine("Olá, digite o seu nome:");
        var nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }

    static void Exercicio02()
    {
        // Solicitando o nome
        Console.WriteLine("Digite seu nome:");
        var nome = Console.ReadLine();

        // Solicitando o sobrenome
        Console.WriteLine("Digite seu sobrenome:");
        var sobrenome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobrenome;

        Console.WriteLine(nomeCompleto);
    }

    static void Exercicio03()
    {
        // Solicitando o primeiro número.
        Console.WriteLine("Digite um número: ");
        var numero01 = double.Parse(Console.ReadLine());

        // Solicitando o segundo número.
        Console.WriteLine("Digite outro número: ");
        var numero02 = double.Parse(Console.ReadLine());

        // Soma
        Console.WriteLine($"Soma: {numero01 + numero02}");

        // Subtração
        Console.WriteLine($"Subtração: {numero01 - numero02}");

        // Multiplicação
        Console.WriteLine($"Multiplicação: {numero01 * numero02}");

        // Divisão
        if (numero02 != 0) Console.WriteLine($"Divisão: {numero01 / numero02}"); else Console.WriteLine($"Divisão: O número não pode ser divisível por 0");

        // Média
        Console.WriteLine($"Média: {(numero01 + numero02) / 2}");
    }

    static void Exercicio04()
    {
        Console.WriteLine("Digite uma ou mais palavras: ");
        var palavras = Console.ReadLine();

        Console.WriteLine($"Você digitou [{palavras}] que tem {palavras.Replace(" ", "").Length} caracteres");
    }
}