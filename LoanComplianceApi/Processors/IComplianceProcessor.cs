using LoanComplianceApi.Controllers.LoanComplianceApi.Request;
using LoanComplianceApi.Controllers.LoanComplianceApi.Response;

namespace LoanComplianceApi.Processors
{
    public interface IComplianceProcessor
    {
        ComplianceResponse Process(ComplianceRequest request);
    }
}
