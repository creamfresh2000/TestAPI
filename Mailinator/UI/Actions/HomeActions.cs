using System.Diagnostics;
using Mailinator.UI.Controls;
using OpenQA.Selenium;

namespace Mailinator.UI.Actions
{
    public class HomeActions
    {
        private readonly HomePage _homePage;


        public HomeActions(IWebDriver driver)
        {
            _homePage = new HomePage(driver);
        }



        public void NavigateTo(string url)
        {
            Debug.WriteLine($"[INFO] : Navigating to page {url}");
            _homePage.NavigateTo(url);
        }

        public void SearchInbox(string mail)
        {
            Debug.WriteLine($"[UI ACTION] : Fill search field with '{mail}' and click button 'Go'");
            _homePage.SearchInput.SendKeys(mail);
            _homePage.GoButton.Click();
        }
    }
}
