using ComplianceCommonLib.Rules;
using ComplianceCommonLib.Rules.APR;
using Microsoft.Extensions.DependencyInjection;

namespace LoanComplianceApi.Infrastructure
{
    public static class APRRulesServiceCollectionExtensions
    {
        public static void AddCaliforniaAPRRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, CA_APR_Conventional_PrimaryHomeRule>();
            services.AddSingleton<IRule, CA_APR_Conventional_SecondaryHomeRule>();
            services.AddSingleton<IRule, CA_APR_FHA_PrimaryHomeRule>();
            services.AddSingleton<IRule, CA_APR_FHA_SecondaryHomeRule>();
            services.AddSingleton<IRule, CA_APR_VA_AllHomesRule>();
        }

        public static void AddMarylandAPRRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, MD_APR_All_AllHomesRule>();
        }

        public static void AddNewYorkAPRRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, NY_APR_Conventional_PrimaryHomeRule>();
            services.AddSingleton<IRule, NY_APR_Conventional_SecondaryHomeRule>();
        }
        public static void AddVirgniaAPRRules(this IServiceCollection services)
        {
            services.AddSingleton<IRule, VA_APR_All_PrimaryHomeRule>();
            services.AddSingleton<IRule, VA_APR_All_SecondaryHomeRule>();
        }
    }
}
