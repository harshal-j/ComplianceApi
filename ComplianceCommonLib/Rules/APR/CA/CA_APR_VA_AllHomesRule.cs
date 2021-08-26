using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.APR
{
    public class CA_APR_VA_AllHomesRule : APRRule
    {
        public CA_APR_VA_AllHomesRule() :
           base(State.CA, 
                new List<LoanType> { LoanType.VA },
                new List<ResidenceType> { ResidenceType.Primary, ResidenceType.Secondary })
        { }

        protected override bool Apply(LoanData loanData)
        {
            return loanData.AnnualPercentageRate <= 3;
        }
    }
}
