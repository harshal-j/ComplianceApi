using ComplianceCommonLib;
using System.ComponentModel.DataAnnotations;

namespace LoanComplianceApi.Controllers.LoanComplianceApi.Request
{
    public class FeeRequest
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public decimal? Amount { get; set; }

        [Required]
        public FeeType? FeeType { get; set; }
    }
}
