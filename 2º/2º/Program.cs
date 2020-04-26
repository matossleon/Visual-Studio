using System;
using System.Dynamic;

namespace _2º
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos têm na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string s = Console.ReadLine();
            string[] ultimoNomeIdadeAltura = s.Split(' ');
            string ultimoNome = ultimoNomeIdadeAltura[0];
            int idade = int.Parse(ultimoNomeIdadeAltura[1]);
            float altura = float.Parse(ultimoNomeIdadeAltura[2]);
            Console.WriteLine("Saída (Números com duas casas decimais");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}
