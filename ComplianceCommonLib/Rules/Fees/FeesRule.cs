using System.Collections.Generic;
using System.Linq;

namespace ComplianceCommonLib.Rules.Fees
{
    public abstract class FeesRule : IRule
    {
        private State _state;

        private List<FeeType> _feeTypesToCheck = new List<FeeType>();

        public FeesRule(State state, List<FeeType> feeTypesToCheck)
        {
            this._state = state;
            this._feeTypesToCheck.AddRange(feeTypesToCheck);
        }

        protected bool IsApplicable(State inputState)
        {
            return this._state == inputState;
        }

        public RuleExecutionResult CheckCompliance(LoanData loanData)
        {
            var passed = false;
            var isApplicable = this.IsApplicable(loanData.State);
            if (isApplicable)
            {
                var loanAmount = loanData.Amount;
                var inputFeesToCheck = loanData.Fees.Where(fee => this._feeTypesToCheck.Any(feeTypetoCheck => feeTypetoCheck == fee.FeeType));
                passed = this.Apply(inputFeesToCheck.Sum(fee => fee.Amount), loanAmount);
            }

            return new RuleExecutionResult(isApplicable, passed, this.GetType().Name);
        }

        protected abstract bool Apply(decimal feesAmount, decimal loanAmount);
    }
}
