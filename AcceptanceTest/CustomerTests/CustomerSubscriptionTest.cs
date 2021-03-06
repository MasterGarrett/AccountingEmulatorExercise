﻿using Core.Models;
using FluentAssertions;
using TechTalk.SpecFlow;
using TestHelpers;

namespace AcceptanceTest.CustomerTests
{
    [Binding]
    class CustomerSubscriptionTest : AcceptanceTestFixtureBase
    {
        private string _phoneNumber = "99998888";
        private ICustomer _customer;
        private ISubscription _subscription;

        [Given(@"I have created a new customer")]
        public void GivenIHaveCreatedANewCustomer()
        {
            _customer = _customerRegistration.CreateCustomer("John Doe", CustomerStatus.Normal);
        }

        [When(@"I sell the customer a phone subscription")]
        public void WhenISellTheCustomerAPhoneSubscription()
        {
            _subscription = SubscriptionHelper.CreateSubscriptionWithDefaultCustomer(_subscriptionRegistration, _customerRegistration, _phoneNumber, "DK", _customer.Status);
        }

        [Then(@"the phone subscription is assigned the customer")]
        public void ThenThePhoneSubscriptionIsAssignedTheCustomer()
        {
            _subscription.Customer.Name.Should().Be(_customer.Name);
        }

        [Then(@"the customer has the initial customer status NORMAL")]
        public void ThenTheCustomerHasTheInitialCustomerStatusNORMAL()
        {
            _subscription.Customer.Status.Should().Be(CustomerStatus.Normal);
        }
    }
}
