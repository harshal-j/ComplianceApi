using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.APR
{
    public class NY_APR_Conventional_SecondaryHomeRule : APRRule
    {
        public NY_APR_Conventional_SecondaryHomeRule() :
         base(State.NY, 
              new List<LoanType> { LoanType.Conventional },
              new List<ResidenceType> { ResidenceType.Secondary })
        { }
        protected override bool Apply(LoanData loanData)
        {
            return loanData.AnnualPercentageRate <= 8;
        }
    }
}
