using System.Configuration;

namespace Sharpforce.Test
{
    public abstract class AbstractSalesforceClientTest
    {
        protected readonly string ConsumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
        protected readonly string ConsumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
        protected readonly string RefreshToken = ConfigurationManager.AppSettings["RefreshToken"];
        protected const string ContactId = "003i000000W2RMDAA3";
    }
}