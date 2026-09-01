using System;

class Program
{
    static void Main()
    {
        //CADASTRO DE VEÍCULO

        Console.WriteLine("=================================");
        Console.WriteLine("       CADASTRO DE VEÍCULO");
        Console.WriteLine("=================================");

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cor: ");
        string cor = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Está disponível para venda? (true/false): ");
        bool disponivel = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       DADOS DO VEÍCULO");
        Console.WriteLine("=================================");

        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Cor: " + cor);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Disponível: " + disponivel);

        Console.ReadKey();
    }
}
