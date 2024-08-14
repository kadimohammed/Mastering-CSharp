using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Delegate
{
    internal class MessagePublisher
    {
        public delegate void SendMessage(string msg);


        public void PublishMessageSMS(string message)
        {
            Console.WriteLine("message envoyer par sms: "+ message);
        }

        public void PublishMessageEmail(string message)
        {
            Console.WriteLine("message envoyer par email: "+ message);
        }

        public void PublishMessageWhatsap(string message)
        {
            Console.WriteLine("message envoyer par whatsap: "+ message);
        }
    }
}
