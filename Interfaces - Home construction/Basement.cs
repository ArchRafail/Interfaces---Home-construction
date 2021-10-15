using System;

namespace Interfaces___Home_construction
{
    class Basement : Item, IPart
    {
        public Basement() { Status = false; }
        public bool Status
        {
            get => status;
            set { status = value; }
        }
        public string ShowPart() => "basement";
    }
}
