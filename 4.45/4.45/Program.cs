using System;

namespace _4._45
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x;
            x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Funcionário: " + x);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            x.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + x);
        }
    }
}
