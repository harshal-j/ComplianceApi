using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.APR
{
    public class VA_APR_All_SecondaryHomeRule : APRRule
    {
        public VA_APR_All_SecondaryHomeRule() :
        base(State.VA, 
             new List<LoanType> { LoanType.Conventional, LoanType.FHA, LoanType.VA },
             new List<ResidenceType> { ResidenceType.Secondary })
        { }
        protected override bool Apply(LoanData loanData)
        {
            return loanData.AnnualPercentageRate <= 8;
        }
    }
}
