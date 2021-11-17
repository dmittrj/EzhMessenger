using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMessenger
{
    [Serializable]
    public class Event
    {
        public string Initiator { get; set; }
        public string E_Object { get; set; }
        public int Happening { get; set; }
        public List<string> Supps = new List<string>();
        public List<string> Protests = new List<string>();
        public DateTime DateOfEnd { get; set; }
    }
}
