using System;

namespace Interfaces___Home_construction
{
    class Window : Item, IPart
    {
        public Window() { Status = false; }
        public bool Status
        {
            get => status;
            set { status = value; }
        }
        public string ShowPart() => "window";
    }
}
