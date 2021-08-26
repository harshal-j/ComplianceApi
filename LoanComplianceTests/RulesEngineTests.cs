using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanComplianceApi;
using Moq;
using ComplianceCommonLib;
using LoanComplianceApi.Infrastructure;
using System.Collections.Generic;
using LoanComplianceApi.Processors;
using LoanComplianceMock;

namespace LoanComplianceTests
{
    [TestClass]
    public class RulesEngineTests
    {
        // An example test mocking the Rules engine. 
        // Similar unit tests can be written to test each component by passing 
        // fake/mocked dependency. 
        [TestMethod]
        public void Processor_Returns_Valid_Response()
        {
            var rulesEngine = new Mock<IRulesEngine>();
            rulesEngine.Setup(engine => engine.ProcessRules(It.IsAny<LoanData>())).Returns(
                new RulesEngineResult(true, new List<ComplianceResult>()));

            var processor = new ComplianceProcessor(rulesEngine.Object);
            var result = processor.Process(ComplianceRequestMock.ComplianceRequest);
            Assert.AreEqual(result.NeedComplianceCheck, true);
        }
    }
}
