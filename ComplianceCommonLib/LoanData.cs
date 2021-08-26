using System.Collections.Generic;

namespace ComplianceCommonLib
{
    public class LoanData
    {
        public LoanType LoanType { get; set; }

        public ResidenceType ResidenceType { get; set; }

        public State State;
        public decimal AnnualPercentageRate { get; set; }

        public decimal Amount;

        public IEnumerable<Fee> Fees;
    }
}
