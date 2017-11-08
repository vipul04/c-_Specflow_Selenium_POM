using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using POMTestProject.Models;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace POMTestProject.PageObjects
{
    public class ContactUsPage : BasePage
    {

        #region Properties

        protected override string PageTitle
        {
            get { return "CONTACT US | QAWorks Limited"; }
        }

        #endregion

        #region Elements

        WebDriverWait wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(20));

        [FindsBy(How = How.Name, Using = "your-name")]
        IWebElement Name;

        [FindsBy(How = How.Name, Using = "your-email")]
        IWebElement Email;

        [FindsBy(How = How.Name, Using = "your-company")]
        IWebElement Subject;

        [FindsBy(How = How.Name, Using = "your-message")]
        IWebElement Message;

        [FindsBy(How = How.Id, Using = "contact-us-send")]
        IWebElement SendBtn;

        #endregion

        #region Public Methods

        public void CompleteContactUsForm(Table table)
        {
            var contactUsForm = table.CreateInstance<ContactUsForm>();
            Name.SendKeys(contactUsForm.Name);
            Email.SendKeys(contactUsForm.Email);
            Subject.SendKeys(contactUsForm.Subject);
            Message.SendKeys(contactUsForm.Message);
            SendBtn.Click();
            WaitForElement(By.CssSelector(".wpcf7-response-output"));
        }

        public bool CheckValidationMessage(string expectedValidationMessage)
        {
            IWebElement validationMessage = Browser.Current.FindElement(By.CssSelector(".wpcf7-response-output"));
            string actualValidationMessage = validationMessage.Text;
            return actualValidationMessage.Contains(expectedValidationMessage);
        }

        #endregion

    }
}
