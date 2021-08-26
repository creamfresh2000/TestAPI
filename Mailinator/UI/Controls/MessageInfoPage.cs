using Mailinator.UI.Controls.Base;
using OpenQA.Selenium;

namespace Mailinator.UI.Controls
{
    public class MessageInfoPage : BasePage
    {
        public MessageInfoPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MailRecipient => Driver.FindElement(By.XPath("//div[contains(text(),'testautomationpaul')]"));

        public IWebElement MailSender => Driver.FindElement(By.XPath("//div[contains(text(),'creamfresh2000@gmail.com')]"));

    }
}
