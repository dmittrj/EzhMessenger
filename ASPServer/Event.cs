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
        public bool ApplyNow { get; set; }
        public List<string> Supps { get; set; }
        public List<string> Protests { get; set; }
        public DateTime DateOfEnd { get; set; }
        public Event(string initiator, string e_Object, int happening, bool applyNow, DateTime dateOfEnd)
        {
            Initiator = initiator;
            E_Object = e_Object;
            Happening = happening;
            ApplyNow = applyNow;
            DateOfEnd = dateOfEnd;
        }

    }
}
