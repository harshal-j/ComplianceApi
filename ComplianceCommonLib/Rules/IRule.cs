namespace ComplianceCommonLib.Rules
{
    public interface IRule
    {
        RuleExecutionResult CheckCompliance(LoanData loanData);
    }
}
