namespace Course.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax;
            if (NumberOfEmployees > 10)
            {
                tax = 0.14;
            }
            else
            {
                tax = 0.16;
            }
            return tax;
        }
        public override double TaxesPaid()
        {
            return Tax() * AnualIncome;
        }
    }
}
