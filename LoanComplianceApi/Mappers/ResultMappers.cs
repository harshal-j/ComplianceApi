using ComplianceCommonLib;
using ComplianceCommonLib.Rules;
using LoanComplianceApi.Controllers.LoanComplianceApi.Request;
using LoanComplianceApi.Controllers.LoanComplianceApi.Response;
using LoanComplianceApi.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace LoanComplianceApi
{
    public static class Mappers
    {
        public static LoanData MapFrom(ComplianceRequest request)
        {
            return new LoanData
            {
                Amount = request.Amount.Value,
                LoanType = request.LoanType.Value,
                ResidenceType = request.ResidenceType.Value,
                Fees = request.Fees.Select(fee => MapFrom(fee)),
                State = request.PropertyLocationState.Value,
                AnnualPercentageRate = request.AnnualPercentageRate.Value
            };
        }

        public static Fee MapFrom(FeeRequest request)
        {
            return new Fee
            {
               FeeType = request.FeeType.Value,
               Amount = request.Amount.Value
            };
        }
        public static ComplianceResult MapFrom(RuleExecutionResult ruleExecutionResult)
        {
            return new ComplianceResult
            {
                RuleName = ruleExecutionResult.RuleName,
                Passed = ruleExecutionResult.Passed
            };
        }
        public static RulesEngineResult MapFrom(bool isComplianceCheckNeeded, IEnumerable<RuleExecutionResult> results)
        {
            return new RulesEngineResult(isComplianceCheckNeeded, results.Select(result => MapFrom(result)));
        }
        public static ComplianceResponse MapFrom(RulesEngineResult result, string loanId)
        {
            return new ComplianceResponse
            {
                LoanId = loanId,
                NeedComplianceCheck = result.IsComplianceCheckNeeded,
                ComplianceResults = result.Results
            };
        } 
    }
}

