using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace POMTestProject.PageObjects
{
    public class Homepage : BasePage
    {
        #region Properties

        protected override string PageTitle
        {
            get { return "QAWorks Limited - Software Quality & Delivery Experts"; }
        }

        #endregion

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
