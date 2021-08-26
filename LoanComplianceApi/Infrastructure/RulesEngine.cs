using System.Collections.Generic;
using System.Linq;
using ComplianceCommonLib;
using ComplianceCommonLib.Rules;
using ComplianceCommonLib.Rules.Global;
using static LoanComplianceApi.Mappers;

namespace LoanComplianceApi.Infrastructure
{
    public class RulesEngine : IRulesEngine
    {
        private readonly IEnumerable<GlobalRule> _globalRules;
        private readonly IEnumerable<IRule> _stateRules;

        public RulesEngine(
            IEnumerable<GlobalRule> globalRules,
            IEnumerable<IRule> stateRules)
        {
            this._globalRules = globalRules;
            this._stateRules = stateRules;
        }

        public RulesEngineResult ProcessRules(LoanData loanData)
        {
            var ruleExecutionResults = new List<RuleExecutionResult>();
            var isComplianceCheckNeeded = this._globalRules.Any(rule => rule.IsComplianceCheckNeeded(loanData));

            if (!isComplianceCheckNeeded)
            { 
                return MapFrom(isComplianceCheckNeeded, ruleExecutionResults);
            }
            return MapFrom(isComplianceCheckNeeded, this._stateRules.Select(rule => rule.CheckCompliance(loanData)).Where(result => result.IsApplicable));
        }
    }
}
