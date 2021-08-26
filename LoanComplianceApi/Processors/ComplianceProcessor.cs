using static LoanComplianceApi.Mappers;
using LoanComplianceApi.Controllers.LoanComplianceApi.Request;
using LoanComplianceApi.Controllers.LoanComplianceApi.Response;

namespace LoanComplianceApi.Processors
{
    public class ComplianceProcessor : IComplianceProcessor
    {
        private readonly IRulesEngine _rulesEngine;
        public ComplianceProcessor(IRulesEngine rulesEngine)
        {
            this._rulesEngine = rulesEngine;
        }

        public ComplianceResponse Process(ComplianceRequest request)
        {
            var loanData = MapFrom(request);
            var complianceResults = this._rulesEngine.ProcessRules(loanData);
            return MapFrom(complianceResults, request.LoanId);
        }
    }
}
