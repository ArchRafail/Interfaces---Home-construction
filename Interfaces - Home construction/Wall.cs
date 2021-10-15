using System;

namespace Interfaces___Home_construction
{
    class Wall : Item, IPart
    {
        public Wall() { Status = false; }
        public bool Status
        {
            get => status;
            set { status = value; }
        }
        public string ShowPart() => "wall";
    }
}
