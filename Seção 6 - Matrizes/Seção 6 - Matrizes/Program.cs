using System;
using System.Linq;

namespace Seção_6___Matrizes
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Digite M e N: ");
            Console.Write("M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a Matriz: ");
            Console.WriteLine();
            int[,] mat = new int[m,n];
            
            for(int i=0; i<m; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++)
                {
                    mat[i, j] = int.Parse(vect[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite o valor desejado: ");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == valor)
                    {
                        Console.WriteLine($"Position {0}, {1}", i,j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j-1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i-1, j]);
                        }
                        if (j < 3)
                        {
                            Console.WriteLine("Right: " + mat[i, j+1]);
                        }
                        if (i < 3)
                        {
                            Console.WriteLine("Down: " + mat[i+1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
