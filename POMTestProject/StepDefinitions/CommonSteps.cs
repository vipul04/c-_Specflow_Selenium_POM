using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using POMTestProject.PageObjects;
using TechTalk.SpecFlow;

namespace POMTestProject.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        IWebDriver currentDriver = null;

        [When(@"I navigate to the Contact Us page")]
        public void WhenINavigateToTheContactUsPage()
        {
            currentDriver = Browser.Current;
            Pages.Homepage.GoToContactUsPage();
            Pages.ContactUsPage.IsAt();
        }


    }
}
