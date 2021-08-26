using System.Diagnostics;
using Mailinator.UI.Controls;
using Mailinator.Utils;
using OpenQA.Selenium;

namespace Mailinator.UI.Actions
{
    public class InboxActions
    {
        private readonly MessageInfoPage _messageInfoPage;
        private readonly PublicMessagesPage _publicMessagesPage;

        public InboxActions(IWebDriver driver)
        {
            _messageInfoPage = new MessageInfoPage(driver);
            _publicMessagesPage = new PublicMessagesPage(driver);
        }

        public void ChooseFirstLetter()
        {
            Debug.WriteLine("[UI ACTION] : Click on first message");
            Wait.UntilTrue(() => _publicMessagesPage.MessageButton.Displayed);
            _publicMessagesPage.MessageButton.Click();
        }

        public string GetRecipientInfo()
        {
            Debug.WriteLine("[ASSERT] : Cheking recipient email address is 'testautomationpaul'");
            Wait.UntilTrue(() => _messageInfoPage.MailRecipient.Displayed);
            return _messageInfoPage.MailRecipient.Text;
            
        }

        public string GetSenderInfo()
        {
            Debug.WriteLine("[ASSERT] : Cheking sender email address is 'creamfresh2000@gmail.com'");
            Wait.UntilTrue(() => _messageInfoPage.MailSender.Displayed);
            return _messageInfoPage.MailSender.Text;
        }

    }
}
