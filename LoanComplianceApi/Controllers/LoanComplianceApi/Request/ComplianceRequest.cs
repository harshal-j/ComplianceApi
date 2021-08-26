using ComplianceCommonLib;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoanComplianceApi.Controllers.LoanComplianceApi.Request
{
    public class ComplianceRequest
    {
        [Required]
        public string LoanId { get; set; }
        
        [Required]
        public LoanType? LoanType { get; set; }

        [Required]
        public ResidenceType? ResidenceType { get; set; }

        [Required]
        public State? PropertyLocationState { get; set; }
        
        [Required]
        public decimal? AnnualPercentageRate { get; set; }
        
        [Required]
        public decimal? Amount { get; set; }
        
        [Required]
        public List<FeeRequest> Fees { get; set; }
    }
}
