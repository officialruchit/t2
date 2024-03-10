namespace Tax_calculator
{
    public class Tax_calculator : InvestmentInfo
    {
        

        public decimal NonTaxableAmount { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TotalTax { get; set; }

        public decimal Slab1Amount { get; set; }
        public decimal Slab2Amount { get; set; }
        public decimal Slab3Amount { get; set; }

        public int Slab2TaxRate { get; set; }
        public int Slab3TaxRate { get; set; }
        public int Slab4TaxRate { get; set; }


        public Tax_calculator(decimal slab1Amount, decimal slab2Amount, decimal slab3Amount, int slab2TaxRate, int slab3TaxRate, int slab4TaxRate)
        {
            Slab1Amount = slab1Amount;
            Slab2Amount = slab2Amount;
            Slab3Amount = slab3Amount;
            Slab2TaxRate = slab2TaxRate;
            Slab3TaxRate = slab3TaxRate;
            Slab4TaxRate = slab4TaxRate;
        }

        // Method to calculate tax details
        public string CalculateTaxDetails(PersonalInfo personalInfo, InvestmentInfo investmentInfo)
        {
            CalcTaxableAmount(investmentInfo, out decimal taxableAmount);
            TaxableAmount = taxableAmount;
            CalcTotalTax(TaxableAmount);
            return "Success"; // Assuming no error occurred
        }

        // Internal method to calculate taxable amount
        private decimal CalcTaxableAmount(InvestmentInfo investmentInfo, out decimal nonTaxableAmount)
        {
            nonTaxableAmount = investmentInfo.HomeLoanOrHouseRentExemption + investmentInfo.ValidInvestment;
            TaxableAmount = 0; // Assuming starting with 0 taxable amount
            return nonTaxableAmount;
        }

        // Internal method to calculate total tax
        private decimal CalcTotalTax(decimal taxableAmount)
        {
            // Calculation of total tax based on taxable amount and tax slabs
            // Assuming implementation for tax calculation
            return TotalTax;
        }

      /*  public string CalculateTaxDetails()*/

    }
}








