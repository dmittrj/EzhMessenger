using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMessenger
{
    [Serializable]
    public class ServInfo
    {
        public List<User> Users { get; set; }
        public List<Chat> Chats { get; set; }
        public int LastChat { get; set; }
        public ServInfo(List<User> users, List<Chat> chats, int lastChat)
        {
            Users = users;
            Chats = chats;
            LastChat = lastChat;
        }

        public ServInfo()
        {
        }
    }
}
