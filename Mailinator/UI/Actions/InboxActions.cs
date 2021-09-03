using System.Diagnostics;
using GmailAPI.Objects;
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
            Wait.UntilTrue(() => !string.IsNullOrEmpty(_messageInfoPage.MailRecipient.Text));
            Debug.WriteLine($"[ASSERT] : Cheking recipient email address.");
            return _messageInfoPage.MailRecipient.Text;
            
        }

        public string GetSenderInfo()
        {
            Wait.UntilTrue(() => !string.IsNullOrEmpty(_messageInfoPage.MailSender.Text));
            Debug.WriteLine($"[ASSERT] : Cheking sender email address.");
            return _messageInfoPage.MailSender.Text;
        }

    }
}
