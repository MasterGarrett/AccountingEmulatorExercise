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
    [NUnit.Framework.DescriptionAttribute("Phone Subscription")]
    public partial class PhoneSubscriptionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PhoneSubscription.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Phone Subscription", "In order to make a better profit on phones\r\nAs an accountant\r\nI want to be able t" +
                    "o define subscriptions which consists of one or more services\r\nAnd register the " +
                    "usage of these services", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create A New Subscription")]
        public virtual void CreateANewSubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create A New Subscription", ((string[])(null)));
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I want to create a new subscription for phone \"23458126\"");
#line 10
 testRunner.When("I have created the subscription");
#line 11
 testRunner.Then("the subscription is registered for phone \"23458126\"");
#line 12
 testRunner.And("the subscription has default local country \"DK\"");
#line 13
 testRunner.And("the subscription contains an empty list of services");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can add a service to a subscription")]
        public virtual void CanAddAServiceToASubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can add a service to a subscription", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I have created a subscription for phone \"23458126\"");
#line 18
 testRunner.When("I add a new Voice Call service to the subcription");
#line 19
 testRunner.Then("the Voice Call service must be added to the list of services");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create A New Subscription With Local Country")]
        public virtual void CreateANewSubscriptionWithLocalCountry()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create A New Subscription With Local Country", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("I want to create a new subscription for phone \"23458126\"");
#line 24
 testRunner.And("I want the local country of the subscription to be \"USD\"");
#line 25
 testRunner.When("I have created the subscription with a not default country");
#line 26
 testRunner.Then("the subscription is registered for phone \"23458126\"");
#line 27
 testRunner.And("the subscription has local country \"USD\"");
#line 28
 testRunner.And("the subscription contains an empty list of services");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find all calls related to a subscription")]
        public virtual void FindAllCallsRelatedToASubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find all calls related to a subscription", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I have created a subscription for phone \"23458126\"");
#line 33
 testRunner.And("the subscription includes a Voice Call service");
#line 34
 testRunner.When("I make a Voice Call with the phone \"23458126\"");
#line 35
 testRunner.Then("I can find the call using the subscription phone number");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
