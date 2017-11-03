using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTestProject.PageObjects
{
    public abstract class BasePage
    {
        #region Properties

        protected abstract string PageTitle { get; }

        #endregion

        #region Public Methods

        public bool IsAt()
        {
            return Browser.Current.Title.Contains(PageTitle);
        }

        public void WaitForElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        #endregion

    }
}
