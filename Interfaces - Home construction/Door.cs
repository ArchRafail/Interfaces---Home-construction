using System;

namespace Interfaces___Home_construction
{
    class Door : Item, IPart
    {
        public Door() { Status = false ; }
        public bool Status
        {
            get => status;
            set { status = value; }
        }
        public string ShowPart() => "door";
    }
}
