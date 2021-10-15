using System;

namespace Interfaces___Home_construction
{
    class Roof : Item, IPart
    {
        public Roof() { Status = false; }
        public bool Status
        {
            get => status;
            set { status = value; }
        }
        public string ShowPart() => "roof";
    }
}
