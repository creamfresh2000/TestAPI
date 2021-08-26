using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using TestProject.Tests.Base;

namespace TestProject.Tests
{

    [TestClass]
    public class GmailTest : GoogleBase
    {
        [TestMethod]
        public void MessagesTest()
        {
            Debug.WriteLine("[STEP] : Getting emails from creamfresh2000@gmail.com");
            var messages = gmailApiActions.ReceiveMessages();

            Debug.WriteLine($"[INFO] : Recieved {messages.Count} messages");
            Debug.WriteLine("[ASSERT] : Ensure that email count is greater than 0");
            Assert.IsTrue(messages.Count > 0);

        }
        
        [TestMethod]
        public void ReceiveFirstMessage ()
        {
            Debug.WriteLine("[STEP] : Getting first email.");
            var body = gmailApiActions.FirstMessage();

            Debug.WriteLine(" [MESSAGE IS] : " + body);
            Assert.IsNotNull(body);

        }

        [TestMethod]
        public void SendMessageTest ()
        {
            Debug.WriteLine("[STEP] : Sending email");
            var sendMessage = gmailApiActions.SendMessage("My test subject", "Message body. Lorem ipsum expiliarmus abrakadabrus.", "testautomationpaul@mailinator.com");
            Debug.WriteLine($"[INFO] : Received message from testautomationpaul@mailinator.com");
            Debug.WriteLine("[ASSERT] : Ensure that first label id equals to 'SENT' ");
            Assert.IsTrue(sendMessage.LabelIds[0].Equals("SENT"));
            
            

        }

    }
}
