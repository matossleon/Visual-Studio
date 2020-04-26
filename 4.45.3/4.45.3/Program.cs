using System;

namespace _4._45._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x;
            x = new Aluno();

            Console.Write("Nome do Aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            x.A = int.Parse(Console.ReadLine());
            x.B = int.Parse(Console.ReadLine());
            x.C = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("NOTA FINAL: " + x.NotaFinal());
            x.Resultado();

        }
    }
}
