using GmailAPI.Builder;
using Mailinator.UI.Actions;

namespace TestAPI.Tests.Base
{
    public class MailinatorBase : BaseUi
    {
        protected HomeActions HomeActions;
        protected InboxActions InboxActions;
        protected EmailBuilder EmailBuilder;
        protected override void Initialize()
        {
            EmailBuilder = new EmailBuilder();
            HomeActions = new HomeActions(Driver);
            InboxActions = new InboxActions(Driver);
        }

        

       
    }
}
