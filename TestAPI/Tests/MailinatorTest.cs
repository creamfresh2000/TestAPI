using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAPI.Tests.Base;

namespace TestAPI.Tests
{
    [TestClass]

    public class MailinatorTest : MailinatorBase 
    {

        [TestMethod]
        public void GmailMailinatorTest()
        {
            var emailInfo = EmailBuilder.StandardEmail();
            Debug.WriteLine("[STEP] : Sending email");
            var sendMessage = GmailApiActions.SendMessage(emailInfo); 
            Debug.WriteLine($"[INFO] : Received message from {emailInfo.Gmail} ");
            Debug.WriteLine("[ASSERT] : Ensure that first label id equals to 'SENT' ");
            Assert.IsTrue(sendMessage.LabelIds[0].Equals("SENT"));
            Debug.WriteLine("[STEP] : Checking the mail for a letter");
            HomeActions.NavigateTo("https://www.mailinator.com/");
            HomeActions.SearchInbox(emailInfo.Mailinator);
            InboxActions.ChooseFirstLetter();
            Assert.IsTrue(InboxActions.GetRecipientInfo().Equals(emailInfo.Mailinator));
            Assert.IsTrue(InboxActions.GetSenderInfo().Equals(emailInfo.Gmail));
        }

    }

}
