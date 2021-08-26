using System.Collections.Generic;

namespace LoanComplianceApi.Controllers.LoanComplianceApi.Response
{
    public class ComplianceResponse
    {
        public string LoanId { get; set; }
        public bool NeedComplianceCheck { get; set; }

        public IEnumerable<ComplianceResult> ComplianceResults { get; set; }
    }
}
