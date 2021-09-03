using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailAPI.Objects;

namespace GmailAPI.Builder
{
    public class EmailBuilder
    {
        public EmailInfo StandardEmail(string gmail = "creamfresh2000@gmail.com")
        {
            return new EmailInfo
            {
                Subject = Faker.Lorem.Sentence(5),
                Body = Faker.Lorem.Paragraph(5),
                Mailinator = Faker.Internet.UserName(),
                Gmail = gmail
            };
        }
    }
}
