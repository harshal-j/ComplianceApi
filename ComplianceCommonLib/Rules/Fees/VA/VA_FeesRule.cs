using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplianceCommonLib.Rules.Fees
{
    public class VA_FeesRule : FeesRule
    {
        public VA_FeesRule() : base(State.VA, new List<FeeType>() {  FeeType.FloodCertification, FeeType.Processing, FeeType.Settlement })
        {}
        protected override bool Apply(decimal feesAmount, decimal loanAmount)
        {
            var feesPercent = 7.00M;
            return feesAmount <= (loanAmount * feesPercent / 100);
        }
    }
}
