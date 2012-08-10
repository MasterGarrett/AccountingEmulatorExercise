﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AcceptanceTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Foreign Country Calls")]
    public partial class ForeignCountryCallsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Foreign Country Calls.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Foreign Country Calls", "In order to make a better profit on phones\r\nAs an accountant\r\nI want my subscribe" +
                    "s be charged differently depending on which country they are calling from and to" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling from local country to foreign country")]
        public virtual void CallingFromLocalCountryToForeignCountry()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling from local country to foreign country", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have a subscription for phone \"23458126\" with local country \"DK\"");
#line 9
 testRunner.And("the subscription is allowed to perform Voice Calls to \"DE\"");
#line 10
 testRunner.And("a Voice Call is performed from \"DK\" to \"DE\"");
#line 11
 testRunner.When("the cost of the call is calculated");
#line 12
 testRunner.Then("the charge is the sum of both calls");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling to local country from foreign country")]
        public virtual void CallingToLocalCountryFromForeignCountry()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling to local country from foreign country", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I have a subscription for phone \"23458126\" with local country \"DK\"");
#line 16
 testRunner.And("the subscription is allowed to perform Voice Calls to \"DE\"");
#line 17
 testRunner.And("a Voice Call is performed from \"DE\" to \"DK\"");
#line 18
 testRunner.When("the cost of the call is calculated");
#line 19
 testRunner.Then("the charge is the sum of both calls");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling to from foreign country to foreign country")]
        public virtual void CallingToFromForeignCountryToForeignCountry()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling to from foreign country to foreign country", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I have a subscription for phone \"23458126\" with local country \"DK\"");
#line 23
 testRunner.And("the subscription is allowed to perform Voice Calls to \"DE\"");
#line 24
 testRunner.And("a Voice Call is performed from \"DE\" to \"DE\"");
#line 25
 testRunner.When("the cost of the call is calculated");
#line 26
 testRunner.Then("the charge is that of the foreign country only");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
