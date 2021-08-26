namespace ComplianceCommonLib.Rules.Global
{
    public class GlobalRule
    {
        public State _state;
        
        public decimal _maximumLoanAmount;

        public LoanType _loanType;

        public GlobalRule(State state, 
                          LoanType loanType, 
                          decimal maximumLoanAmount)
        {
            this._state = state;
            this._loanType = loanType;
            this._maximumLoanAmount = maximumLoanAmount;
        }

        public bool IsComplianceCheckNeeded(LoanData loanData)
        {
            return this._state == loanData.State &&
                   this._loanType == loanData.LoanType &&
                   this._maximumLoanAmount >= loanData.Amount;
        }
    }
}