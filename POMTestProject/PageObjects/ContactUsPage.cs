﻿using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using POMTestProject.Models;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace POMTestProject.PageObjects
{
    public class ContactUsPage
    {
        public ContactUsPage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }

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

        //[FindsBy(How = How.CssSelector, Using = ".wpcf7-response-output.wpcf7-display-none.fusion-alert.wpcf7-mail-sent-ok")]
        //IWebElement ConfirmationMessage;

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
            By locator = By.CssSelector(".wpcf7-response-output.wpcf7-display-none.fusion-alert.wpcf7-mail-sent-ok");
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public bool CheckConfirmationMessage(string expectedConfirmationMessage)
        {
            IWebElement ConfirmationMessage = Browser.Current.FindElement(By.CssSelector(".wpcf7-mail-sent-ok"));
            string actualConfirmationMessage = ConfirmationMessage.Text;
            return actualConfirmationMessage.Equals(expectedConfirmationMessage);
        }

        #endregion

    }
}