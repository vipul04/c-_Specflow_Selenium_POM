using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTestProject.PageObjects
{
    public class Homepage
    {
        public Homepage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }

        #region Elements

        [FindsBy(How = How.CssSelector, Using = "#menu-item-18894")]
        public IWebElement ContactUsBtn;

        #endregion

        #region Public Methods

        public ContactUsPage GoToContactUsPage()
        {
            ContactUsBtn.Click();
            return new ContactUsPage();
        }
        #endregion
    }
}
