namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; } = 0;

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax;
            if (AnualIncome < 20000.00)
            {
                tax = 0.15;
            }
            else
            {
                tax = 0.25;
            }
            return tax;
        }

        public override double TaxesPaid()
        {
            return Tax() * AnualIncome - 0.5 * HealthExpenditures;
        }
    }
}
