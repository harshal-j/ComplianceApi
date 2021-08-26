using ComplianceCommonLib;
using LoanComplianceApi.Controllers.LoanComplianceApi.Request;
using System.Collections.Generic;

namespace LoanComplianceMock
{
    public static class ComplianceRequestMock
    {
        public static ComplianceRequest ComplianceRequest => new ComplianceRequest
        {
            LoanId = "1",
            PropertyLocationState = State.CA,
            Amount = 100000M,
            Fees = Fees,
            AnnualPercentageRate = 5.0M,
            LoanType = LoanType.Conventional,
            ResidenceType = ResidenceType.Primary,

        };

        public static List<FeeRequest> Fees
        {
            get
            {
                return new List<FeeRequest>{
                        new FeeRequest
                        {
                            Id = "1",
                            FeeType = FeeType.FloodCertification,
                            Amount = 1000
                        }
                };
            }
        }
    }
}
