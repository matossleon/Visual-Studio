using System;

namespace Seção_4__Classes__objetos_e_atributos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Dados da segunda pessoa:");
            Console.WriteLine();
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a.Idade == b.Idade)
            {
                Console.WriteLine("As duas pessoas tem a mesma idade");
            }
            else if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }
        }
    }
}
