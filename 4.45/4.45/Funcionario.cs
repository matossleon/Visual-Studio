

namespace _4._45
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return (SalarioBruto - Imposto);
        }

        public void AumentarSalario(double Aumento)
        {
            SalarioBruto *= ((100 + Aumento) / 100);
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2");
        }
    }
}
