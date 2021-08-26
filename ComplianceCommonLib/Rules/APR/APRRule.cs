using System.Collections.Generic;
using System.Linq;

namespace ComplianceCommonLib.Rules.APR
{
    public abstract class APRRule : IRule
    {
        private State _state;

        private List<LoanType> _appliesToLoanTypes = new List<LoanType>();
        private List<ResidenceType> _residenceTypes = new List<ResidenceType>();

        public APRRule(State state, 
                       IEnumerable<LoanType> appliesToLoanTypes, 
                       IEnumerable<ResidenceType> residenceTypes)
        {
            this._state = state;
            this._residenceTypes.AddRange(residenceTypes);
            this._appliesToLoanTypes.AddRange(appliesToLoanTypes);
        }

        protected bool IsApplicable(State inputState, LoanType inputLoanType, ResidenceType inputResidenceType)
        {
            return this._state == inputState && 
                   _appliesToLoanTypes.Any(loanType => inputLoanType == loanType) && 
                   _residenceTypes.Any(residenceType => inputResidenceType == residenceType);
        }

        public RuleExecutionResult CheckCompliance(LoanData loanData)
        {
            var passed = false;
            var isApplicable = this.IsApplicable(loanData.State, loanData.LoanType, loanData.ResidenceType);
            if (isApplicable)
            {
                passed = this.Apply(loanData);
            }

            return new RuleExecutionResult(isApplicable, passed, this.GetType().Name);
        }

        protected abstract bool Apply(LoanData loanData);
    }
}
