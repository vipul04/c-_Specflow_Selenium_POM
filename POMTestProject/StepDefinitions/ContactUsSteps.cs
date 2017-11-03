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
            currentDriver = Browser.Current;
            currentDriver.Manage().Window.Maximize();
        }

        [When(@"enter the following information")]
        public void WhenEnterTheFollowingInformation(Table table)
        {
            Pages.ContactUsPage.CompleteContactUsForm(table);
        }

        [Then(@"I should see the ""(.*)""")]
        public void ThenIShouldSeeThe(string expectedConfirmationMessage)
        {
            Assert.IsTrue(Pages.ContactUsPage.CheckConfirmationMessage(expectedConfirmationMessage));
        }
    }
}
