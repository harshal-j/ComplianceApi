using ComplianceCommonLib;
using LoanComplianceApi.Infrastructure;

namespace LoanComplianceApi
{
    public interface IRulesEngine
    {
        public RulesEngineResult ProcessRules(LoanData loanData);
    }
}
