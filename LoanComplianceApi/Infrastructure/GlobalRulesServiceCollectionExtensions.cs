using ComplianceCommonLib;
using ComplianceCommonLib.Rules.Global;
using Microsoft.Extensions.DependencyInjection;

namespace LoanComplianceApi.Infrastructure
{
    public static class GlobalRulesServiceCollectionExtensions
    {
        public static void AddGlobalRules(this IServiceCollection services)
        {
            // We can get this from configuration too for each state.
            var state = State.NY;
            var maxLoanAmount = 750000M;
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.Conventional, maxLoanAmount));

            state = State.VA;
            maxLoanAmount = decimal.MaxValue;
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.Conventional, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.Conventional, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.FHA, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.VA, maxLoanAmount));

            state = State.MD;
            maxLoanAmount = 400000;
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.Conventional, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.FHA, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.VA, maxLoanAmount));

            state = State.CA;
            maxLoanAmount = 600000;
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.Conventional, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.FHA, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.VA, maxLoanAmount));

            state = State.FL;
            maxLoanAmount = decimal.MaxValue;
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.Conventional, maxLoanAmount));
            services.AddSingleton(typeof(GlobalRule), new GlobalRule(state, LoanType.VA, maxLoanAmount));
        }
    }
}
