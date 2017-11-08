using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using POMTestProject.PageObjects;
using System.Configuration;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POMTestProject.StepDefinitions
{
    [Binding]
    public class ContactUsSteps
    {

        IWebDriver currentDriver = null;

        [Given(@"I am on the QAWorks Site")]
        public void GivenIAmOnTheQAWorksSite()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            Browser.Current.Manage().Window.Maximize();
            currentDriver = Browser.Current;
        }

        [When(@"enter the following information")]
        public void WhenEnterTheFollowingInformation(Table table)
        {
            Pages.ContactUsPage.CompleteContactUsForm(table);
        }

        [Then(@"I should see the message ""(.*)""")]
        public void ThenIShouldSeeTheMessage(string expectedValidationMessage)
        {
            Assert.IsTrue(Pages.ContactUsPage.CheckValidationMessage(expectedValidationMessage));
        }
    }
}
