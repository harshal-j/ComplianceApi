using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.APR
{
    public class CA_APR_Conventional_SecondaryHomeRule : APRRule
    {
        public CA_APR_Conventional_SecondaryHomeRule() :
         base(State.CA,
              new List<LoanType> { LoanType.Conventional },
              new List<ResidenceType> { ResidenceType.Secondary }) 
        { }

        protected override bool Apply(LoanData loanData)
        {
            return loanData.AnnualPercentageRate <= 4;
        }
    }
}