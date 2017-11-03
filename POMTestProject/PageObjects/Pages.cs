using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium.Support.PageObjects;


namespace POMTestProject.PageObjects
{
    public static class Pages
    {
        public static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Current, page);
            return page;
        }

        #region Pages

        public static Homepage Homepage
        {
            get { return GetPage<Homepage>(); }
        }

        public static ContactUsPage ContactUsPage
        {
            get { return GetPage<ContactUsPage>(); }
        }

        #endregion
    }
}
