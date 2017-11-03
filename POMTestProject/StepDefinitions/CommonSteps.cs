using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using POMTestProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
