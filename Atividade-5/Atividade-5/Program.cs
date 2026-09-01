using System;

class Program
{
    static void Main()
    {
        //CADASTRO DE FUNCIONÁRIO

        Console.WriteLine("=================================");
        Console.WriteLine("     CADASTRO DE FUNCIONÁRIO");
        Console.WriteLine("=================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Cargo: ");
        string cargo = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Salário: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("O funcionário está ativo? (true/false): ");
        bool ativo = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       FICHA DO FUNCIONÁRIO");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Idade: " + idade + " anos");
        Console.WriteLine("Salário: R$ " + salario);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Ativo: " + ativo);

        Console.ReadKey();
    }
}
