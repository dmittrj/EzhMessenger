using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMessenger
{
    [Serializable]
    public class Member
    {
        public string Nick { get; set; }
        public int Role { get; set; }
        public bool Blocked { get; set; }
        public Member(string nick, int role, bool blocked)
        {
            Nick = nick;
            Role = role;
            Blocked = blocked;
        }
    }
}
