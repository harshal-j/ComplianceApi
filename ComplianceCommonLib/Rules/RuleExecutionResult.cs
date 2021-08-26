namespace ComplianceCommonLib.Rules
{
    public class RuleExecutionResult
    {
        public bool IsApplicable { get; }
        public bool Passed { get; }

        public string RuleName { get; }

        public RuleExecutionResult(bool isApplicable, bool passed, string ruleName)
        {
            this.Passed = passed;
            this.RuleName = ruleName;
            this.IsApplicable = isApplicable;
        }
    }
}
