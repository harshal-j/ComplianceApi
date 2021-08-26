using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.Fees
{
    public class FL_FeesRule : FeesRule
    {
        public FL_FeesRule() : base(State.FL, new List<FeeType>() { FeeType.Application, FeeType.FloodCertification, FeeType.TitleSearch })
        { }
        protected override bool Apply(decimal feesAmount, decimal loanAmount)
        {
            var feesPercent = (loanAmount <= 20000) ? 6.00M :
                              (loanAmount <= 75000) ? 8.00M :
                              (loanAmount <= 75000) ? 8.00M : 10.00M;
            return feesAmount <= (loanAmount * feesPercent / 100);
        }
    }
}
