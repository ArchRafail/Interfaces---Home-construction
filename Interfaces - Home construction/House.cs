using System;
using System.Collections.Generic;

namespace Interfaces___Home_construction
{
    class House
    {
        List<IPart> ListOfParts;
        public House()
        {
            ListOfParts = new List<IPart>
            {
                new Basement(), new Wall(), new Wall(), new Wall(),
                new Wall(), new Door(), new Window(), new Window(),
                new Window(), new Window(), new Roof()
            };
        }
        public List<IPart> GetList() => ListOfParts;
    }
}
