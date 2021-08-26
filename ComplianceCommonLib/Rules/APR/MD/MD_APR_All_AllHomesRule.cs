using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.APR
{
    public class MD_APR_All_AllHomesRule : APRRule
    {
        public MD_APR_All_AllHomesRule() :
          base(State.MD, 
               new List<LoanType> { LoanType.VA, LoanType.Conventional, LoanType.FHA },
               new List<ResidenceType> { ResidenceType.Primary, ResidenceType.Secondary })

        { }
        protected override bool Apply(LoanData loanData)
        {
            return loanData.AnnualPercentageRate <= 4;
        }
    }
}
