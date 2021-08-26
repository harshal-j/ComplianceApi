using System.Collections.Generic;

namespace ComplianceCommonLib.Rules.Fees
{
    public class CA_FeesRule : FeesRule
    {
        public CA_FeesRule() : base(State.CA, new List<FeeType>() { FeeType.Application, FeeType.Settlement })
        { }
        protected override bool Apply(decimal feesAmount, decimal loanAmount)
        {
            var feesPercent = (loanAmount <= 50000)  ? 3.00M : 
                              (loanAmount <= 150000) ? 4.00M : 5.00M;
            return feesAmount <= (loanAmount * feesPercent / 100);
        }
    }
}
