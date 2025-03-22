namespace DesafioPratico_01;

class Program
{
    static void Main()
    {
        Exercicio02();
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
        string nome = Console.ReadLine();

        // Solicitando o sobrenome
        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobrenome;

        Console.WriteLine(nomeCompleto);
    }
}