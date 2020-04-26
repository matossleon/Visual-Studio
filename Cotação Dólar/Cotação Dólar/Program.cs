using System;

namespace Cotação_Dólar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual é a cotação do dólar?");
            ConversordeMoeda.Cot = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar?");
            ConversordeMoeda.Qnt = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais: " + ConversordeMoeda.Conversao());
        }
        
    }
}
