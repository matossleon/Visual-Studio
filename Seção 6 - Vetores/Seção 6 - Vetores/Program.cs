using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Seção_6___Vetores {
    class Program {
        static void Main(string[] args) {


            Console.Write("Quantos quartos vão ser alugados? ");
            int n = int.Parse(Console.ReadLine());
            Estudante[] est = new Estudante[10];
            Console.WriteLine("Digite o nome e email dos estudantes: ");

            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel {i + 1}: ");
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto escolhido: ");
                int quarto = int.Parse(Console.ReadLine());
                est[quarto] = new Estudante(nome, email);
            }
            for (int i = 0; i < 10; i++) {
                if (est[i] != null) {
                    Console.WriteLine(i + ": " + est[i]);
                }
            }
        }
    }
}
