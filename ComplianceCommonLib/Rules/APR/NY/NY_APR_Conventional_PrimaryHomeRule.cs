using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.APR
{
    public class NY_APR_Conventional_PrimaryHomeRule : APRRule
    {
        public NY_APR_Conventional_PrimaryHomeRule() :
          base(State.NY, 
               new List<LoanType> { LoanType.Conventional },
               new List<ResidenceType> { ResidenceType.Primary })
        { }
        protected override bool Apply(LoanData loanData)
        {
            return loanData.AnnualPercentageRate <= 6;
        }
    }
}
