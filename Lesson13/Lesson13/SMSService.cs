using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
   public class SMSService1: ISMSService
    {
        private string _sender = "TestSMS";
        public void SendSMS(string phoneNumber,string TextMessage)
        {
            //Custom logic1
            Console.WriteLine($"I am sending sms with Provider1 to {phoneNumber} and text is {TextMessage}");
        }


    }

    public class SMSService2: ISMSService
    {
        private string _sender = "TestSMS";
        public void SendSMS(string phoneNumber, string TextMessage)
        {
            //Custom logic2
            Console.WriteLine($"Sms is sent with Provider2 to {phoneNumber} and text is {TextMessage}");
        }


    }
    public interface ISMSService
    {
        void SendSMS(string phoneNumber, string TextMessage);
    }
}
