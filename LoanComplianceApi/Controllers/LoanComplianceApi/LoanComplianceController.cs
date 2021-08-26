using Microsoft.AspNetCore.Mvc;
using LoanComplianceApi.Controllers.LoanComplianceApi.Request;
using LoanComplianceApi.Processors;

namespace LoanValiationApi.Controllers.LoanComplianceApi
{
    [ApiController]
    [Route("[controller]")]
    public class LoanComplianceController : ControllerBase
    {
        private readonly IComplianceProcessor _processor;

        public LoanComplianceController( IComplianceProcessor processor)
        {
            this._processor = processor;
        }

        [HttpPost]
        public IActionResult ValidateLoanCompliance(ComplianceRequest request)
        {
            return this.Ok(this._processor.Process(request));
        }
    }
}
