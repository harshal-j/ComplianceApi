using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.APR
{
    public class CA_APR_FHA_PrimaryHomeRule : APRRule
    {
        public CA_APR_FHA_PrimaryHomeRule() :
         base(State.CA,
              new List<LoanType> { LoanType.FHA },
              new List<ResidenceType> { ResidenceType.Primary } )
        { }

        protected override bool Apply(LoanData loanData)
        {
            return loanData.AnnualPercentageRate <= 5;
        }
    }
}