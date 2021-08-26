using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.Fees
{
    public class MD_FeesRule : FeesRule
    {
        public MD_FeesRule() : base(State.MD, new List<FeeType>() { FeeType.Application, FeeType.CreditReport })
        { }
        protected override bool Apply(decimal feesAmount, decimal loanAmount)
        {
            var feesPercent = (loanAmount <= 200000) ? 4.00M : 6.00M;
            return feesAmount <= (loanAmount * feesPercent / 100);
        }
    }
}
