using Mailinator.UI.Controls.Base;
using OpenQA.Selenium;

namespace Mailinator.UI.Controls
{
    public class MessageInfoPage : BasePage
    {
        public MessageInfoPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MailRecipient => Driver.FindElement(By.XPath("//div[contains(text(),'To')]/following-sibling::div"));

        public IWebElement MailSender => Driver.FindElement(By.XPath("//div[contains(text(),'From')]/following-sibling::div"));

    }
}
