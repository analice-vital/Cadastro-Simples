using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 07 - CADASTRO DE JOGO

        Console.WriteLine("=================================");
        Console.WriteLine("         CADASTRO DE JOGO");
        Console.WriteLine("=================================");

        Console.Write("Nome do jogo: ");
        string nome = Console.ReadLine();

        Console.Write("Plataforma: ");
        string plataforma = Console.ReadLine();

        Console.Write("Ano de lançamento: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        Console.Write("Preço: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade de jogadores: ");
        int jogadores = Convert.ToInt32(Console.ReadLine());

        Console.Write("O jogo está instalado? (true/false): ");
        bool instalado = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("          DADOS DO JOGO");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Plataforma: " + plataforma);
        Console.WriteLine("Ano de lançamento: " + ano);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Jogadores: " + jogadores);
        Console.WriteLine("Instalado: " + instalado);

        Console.ReadKey();
    }
}
