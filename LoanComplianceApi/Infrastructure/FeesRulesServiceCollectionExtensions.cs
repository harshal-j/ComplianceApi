using ComplianceCommonLib.Rules;
using ComplianceCommonLib.Rules.Fees;
using Microsoft.Extensions.DependencyInjection;

namespace LoanComplianceApi.Infrastructure
{
    public static class FeesRulesServiceCollectionExtensions
    {
        public static void AddCaliforniaFeesRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, CA_FeesRule>();
        }

        public static void AddMarylandFeesRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, MD_FeesRule>();
        }

        public static void AddFloridaFeesRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, FL_FeesRule>();
        }

        public static void AddVirginiaFeesRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, VA_FeesRule>();
        }
    }
}
