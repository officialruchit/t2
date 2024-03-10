using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_calculator
{
    public class InvestmentInfo
    {
        public decimal income { get; set; }
       
        public int HomeLoanOrHouseRentExemption { get; internal set; }
        public int ValidInvestment { get; internal set; }

        InvestmentInfo(decimal income, decimal investIncome, decimal houseLoan)
        {
            this.income = income;
            this.ValidInvestment = ValidInvestment;
            HomeLoanOrHouseRentExemption = HomeLoanOrHouseRentExemption;
        }   
    }
}
