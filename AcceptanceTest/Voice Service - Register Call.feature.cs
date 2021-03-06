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
    [NUnit.Framework.DescriptionAttribute("Voice Service - Register Call")]
    public partial class VoiceService_RegisterCallFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Voice Service - Register Call.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Voice Service - Register Call", "In order to make a profit on voice calls\r\nAs an accountant\r\nI must be able to reg" +
                    "ister voice calls by a set of parameters to calculate the bill for a customer", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Register Local Voice Call")]
        [NUnit.Framework.TestCaseAttribute("09:00:00", "00:01:37", "98561234", "DK", "DK", new string[0])]
        [NUnit.Framework.TestCaseAttribute("15:41:02", "00:02:15", "23458126", "DK", "DK", new string[0])]
        [NUnit.Framework.TestCaseAttribute("18:29:56", "00:28:09", "98561234", "DK", "DK", new string[0])]
        public virtual void RegisterLocalVoiceCall(string startTime, string duration, string receiver, string sourceCountry, string destinationCountry, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register Local Voice Call", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("a subscription with phone number \"77889955\" exists");
#line 8
 testRunner.And("the subscription includes the Voice Call Service");
#line 9
 testRunner.And(string.Format("the customer makes a Voice Call at \"{0}\"", startTime));
#line 10
 testRunner.And(string.Format("the call lasts \"{0}\"", duration));
#line 11
 testRunner.And(string.Format("the call is made to number: \"{0}\"", receiver));
#line 12
 testRunner.And(string.Format("the call is made from: \"{0}\"", sourceCountry));
#line 13
 testRunner.And(string.Format("the call is made to: \"{0}\"", destinationCountry));
#line 14
 testRunner.When("the call ends");
#line 15
 testRunner.Then("I must be able to find the call using the subscription");
#line 16
 testRunner.And(string.Format("the start time of the call must be registered at \"{0}\"", startTime));
#line 17
 testRunner.And(string.Format("the duration of the call must be registered to have lasted \"{0}\" m:s", duration));
#line 18
 testRunner.And(string.Format("the receiver of the call must be registered as \"{0}\"", receiver));
#line 19
 testRunner.And(string.Format("the country from which the call was made must be registered as \"{0}\"", sourceCountry));
#line 20
 testRunner.And(string.Format("the country for which the call was made to must be registered as \"{0}\"", destinationCountry));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register Foreign Voice Call")]
        [NUnit.Framework.TestCaseAttribute("09:00:00", "00:01:37", "98561234", "DE", "DK", new string[0])]
        [NUnit.Framework.TestCaseAttribute("15:41:02", "00:02:15", "23458126", "DK", "DE", new string[0])]
        [NUnit.Framework.TestCaseAttribute("18:29:56", "00:28:09", "98561234", "DE", "DE", new string[0])]
        public virtual void RegisterForeignVoiceCall(string startTime, string duration, string receiver, string sourceCountry, string destinationCountry, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register Foreign Voice Call", exampleTags);
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("a subscription with phone number \"77889955\" exists");
#line 31
 testRunner.And("the subscription includes the Voice Call Service");
#line 32
 testRunner.And(string.Format("the subscription includes support for calling from country: \"{0}\"", sourceCountry));
#line 33
 testRunner.And(string.Format("the subscription includes support for calling to country: \"{0}\"", destinationCountry));
#line 34
 testRunner.And(string.Format("the customer makes a Voice Call at \"{0}\"", startTime));
#line 35
 testRunner.And(string.Format("the call lasts \"{0}\"", duration));
#line 36
 testRunner.And(string.Format("the call is made to number: \"{0}\"", receiver));
#line 37
 testRunner.And(string.Format("the call is made from: \"{0}\"", sourceCountry));
#line 38
 testRunner.And(string.Format("the call is made to: \"{0}\"", destinationCountry));
#line 39
 testRunner.When("the call ends");
#line 40
 testRunner.Then("I must be able to find the call using the subscription");
#line 41
 testRunner.And(string.Format("the start time of the call must be registered at \"{0}\"", startTime));
#line 42
 testRunner.And(string.Format("the duration of the call must be registered to have lasted \"{0}\" m:s", duration));
#line 43
 testRunner.And(string.Format("the receiver of the call must be registered as \"{0}\"", receiver));
#line 44
 testRunner.And(string.Format("the country from which the call was made must be registered as \"{0}\"", sourceCountry));
#line 45
 testRunner.And(string.Format("the country for which the call was made to must be registered as \"{0}\"", destinationCountry));
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
