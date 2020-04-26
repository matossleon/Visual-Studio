using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Seção_6___Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < a; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < b; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }


            Console.Write("O curso C possui quantos alunos? ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < c; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();
            A.UnionWith(B);
            A.UnionWith(C);
            int count = 0;
            foreach(int obj in A)
            {
                count++;
            }
            Console.WriteLine("Total de Alunos: " + count);
        }
    }
}
