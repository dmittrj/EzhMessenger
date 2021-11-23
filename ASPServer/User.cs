using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMessenger
{
    [Serializable]
    public class User
    {
        public string Nickname { get; set; }
        public DateTime Status { get; set; }
        public List<int> Chats { get; set; } = new List<int>();
        public int Password { get; set; }
        public User(string nickname, int password)
        {
            Nickname = nickname;
            Status = DateTime.Now;
            Chats.Add(0);
            Password = password;
        }

        public bool CompareName(string str)
        {
            if (Nickname == str) return true; else return false;
        }

        public void DeleteEmptyChats()
        {
            for (int i = 0; i < Chats.Count; i++)
                if (Chats[i] == -1)
                {
                    Chats.RemoveAt(i);
                    break;
                }
        }
    }
}
