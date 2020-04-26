using System;

namespace Seção_5 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria contaBancaria;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial: (s/n); ");

            bool depositoInicial = (char.Parse(Console.ReadLine()) == 's');
            if (depositoInicial) {
                Console.Write("Digite o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(numero, nome, saldo);
            }
            else {
                contaBancaria = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Digite um valor para depósito: ");
            contaBancaria.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Digite um valor para saque: ");
            contaBancaria.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
        }
    }
}
