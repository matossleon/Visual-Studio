using System;

namespace _4._45._3
{
    class Aluno
    {
        public string Nome;
        public int A, B, C;

        public int NotaFinal()
        {
            return (A + B + C);
        }

        public void Resultado()
        {
 
            int restante = 60 - NotaFinal();
            if(NotaFinal() > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {restante} PONTOS");
            }
        }
    }
}
