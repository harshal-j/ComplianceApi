using ComplianceCommonLib;
using ComplianceCommonLib.Rules;
using ComplianceCommonLib.Rules.Fees;
using ComplianceCommonLib.Rules.Global;
using LoanComplianceApi.Processors;
using Microsoft.Extensions.DependencyInjection;

namespace LoanComplianceApi.Infrastructure
{
    public static class LoanComplianceSeviceCollectionExtensions
    {
        public static void AddLoanComplianceServices(this IServiceCollection services)
        {
            services.AddGlobalRules();
            
            services.AddCaliforniaAPRRules();
            services.AddMarylandAPRRules();
            services.AddNewYorkAPRRules();
            services.AddVirgniaAPRRules();

            services.AddCaliforniaFeesRules();
            services.AddMarylandFeesRules();
            services.AddVirginiaFeesRules();
            services.AddFloridaFeesRules();

            services.AddScoped<IComplianceProcessor, ComplianceProcessor>();
            services.AddScoped<IRulesEngine, RulesEngine>();
        }
    }
}
