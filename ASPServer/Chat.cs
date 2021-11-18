using CourseMessenger;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMessenger
{
    [Serializable]
    public class Chat
    {
        public int IdChat { get; set; }
        public string ChatName { get; set; }
        public bool IsDeleting { get; set; }
        public DateTime DateDel { get; set; }

        public List<Message> ChatMsgs = new List<Message>();

        public List<Member> ChatMmbrs { get; set; }
        public List<Event> Events = new List<Event>();
        public bool Secret { get; set; }
        [JsonConstructor]
        public Chat(int idChat, string chatName, List<Member> chatMmbrs, bool secret)
        {
            IdChat = idChat;
            ChatName = chatName;
            IsDeleting = false;
            DateDel = DateTime.Now;
            ChatMmbrs = chatMmbrs;
            Secret = secret;
        }

        //[JsonConstructor]
        public Chat()
        {
        }

    }
}
