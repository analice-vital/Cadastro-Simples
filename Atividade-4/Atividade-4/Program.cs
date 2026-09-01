using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 04 - CADASTRO DE FILME

        Console.WriteLine("=================================");
        Console.WriteLine("        CADASTRO DE FILME");
        Console.WriteLine("=================================");

        Console.Write("Nome do filme: ");
        string filme = Console.ReadLine();

        Console.Write("Nome do diretor: ");
        string diretor = Console.ReadLine();

        Console.Write("Ano de lançamento: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        Console.Write("Duração em minutos: ");
        int duracao = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nota do filme: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        Console.Write("O filme já foi assistido? (true/false): ");
        bool assistido = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("          DADOS DO FILME");
        Console.WriteLine("=================================");

        Console.WriteLine("Filme: " + filme);
        Console.WriteLine("Diretor: " + diretor);
        Console.WriteLine("Ano de lançamento: " + ano);
        Console.WriteLine("Duração: " + duracao + " minutos");
        Console.WriteLine("Nota: " + nota);
        Console.WriteLine("Assistido: " + assistido);

        Console.ReadKey();
    }
}