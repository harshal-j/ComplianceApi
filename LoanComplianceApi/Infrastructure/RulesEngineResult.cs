using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanComplianceApi.Infrastructure
{
    public class RulesEngineResult
    {
        public bool IsComplianceCheckNeeded { get; }

        public IEnumerable<ComplianceResult> Results { get; }

        public RulesEngineResult(bool isComplianceCheckNeeded, IEnumerable<ComplianceResult> results)
        {
            this.IsComplianceCheckNeeded = isComplianceCheckNeeded;
            this.Results = results;
        }
    }
}
