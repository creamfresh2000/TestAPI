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
            Debug.WriteLine("[STEP] : Sending email");
            var sendMessage = GmailApiActions.SendMessage("My test subject", "Message body. Lorem ipsum expiliarmus abrakadabrus.", "testautomationpaul@mailinator.com");
            Debug.WriteLine("[INFO] : Received message from creamfresh2000@gmail.com");
            Debug.WriteLine("[ASSERT] : Ensure that first label id equals to 'SENT' ");
            Assert.IsTrue(sendMessage.LabelIds[0].Equals("SENT"));
            Debug.WriteLine("[STEP] : Checking the mail for a letter");
            HomeActions.NavigateTo("https://www.mailinator.com/");
            HomeActions.SearchInbox("testautomationpaul");
            InboxActions.ChooseFirstLetter();
            Assert.IsTrue(InboxActions.GetRecipientInfo().Equals("testautomationpaul"));
            Assert.IsTrue(InboxActions.GetSenderInfo().Equals("creamfresh2000@gmail.com"));
        }

    }

}
