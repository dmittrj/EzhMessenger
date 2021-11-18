using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseMessenger
{
    [Serializable]
    public class Message
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ClientNotify;
        public Message(string userName, string messageText, DateTime timeStamp)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }



        public Message()
        {
            UserName = "Frog";
            MessageText = "Server is running";
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            string output = String.Format("{0} <{2}>: {1}", UserName, MessageText, TimeStamp);
            return output;
        }
    }
}
