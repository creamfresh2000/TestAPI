using GmailAPI.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject.Tests.Base
{
    [TestClass]
    public class GoogleBase
    {
        protected GmailApiActions gmailApiActions;

        [TestInitialize]
        [System.Obsolete]
        public void Initialize()
        {
            gmailApiActions = new GmailApiActions();
        }


    }
}
