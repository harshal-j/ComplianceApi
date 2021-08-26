# ComplianceApi

Notes :- 

1) As there are no network bound operations, I have not added async/await pattern in the code. 
2) Just shown one example test setup and we can build on top of that to unit test all components individually. 
3) The rules data (i.e can come from config file ( either json or from DB as well, depending on the needs) but they are harcoded in C# files. 
4) Sample json payload to test the API  

{
 "LoanId" : "1", 
 "LoanType" : "FHA",
 "ResidenceType" : "Primary",
 "PropertyLocationState" : "CA",
 "AnnualPercentageRate" : 5.1,
 "Amount" : 600000,
 "Fees" : [{
 	"Id" : "1",
 	"FeeType" : "Settlement",
 	"Amount" : 60000
 }]
}
