using System;
using System.Collections.Generic;

namespace Interfaces___Home_construction
{
    class TeamLeader : IWorker
    {
        string name;
        public TeamLeader(string name) { this.name = name; }
        string checkStatus(bool status)
        {
            return status == true ? "is finished" : "didn't built";
        }
        public void ShowWorker()
        {
            Console.WriteLine("Hello guys. I'm a builder's teamleader.");
            Console.WriteLine($"My name - {name} and I will show you a report about building process.\n");
        }
        public void BuildShow(List<IPart> list)
        {
            bool check = false;
            int wall = 1, window = 1;
            Console.WriteLine();
            foreach (var obj in list)
            {
                if (obj is Basement)
                {
                    obj.ShowPart();
                    Console.WriteLine($" - {checkStatus(obj.Status)}.");
                }
                if (obj is Wall)
                {
                    obj.ShowPart();
                    Console.WriteLine($"{wall++} - {checkStatus(obj.Status)}.");
                }
                if (obj is Door)
                {
                    obj.ShowPart();
                    Console.WriteLine($" - {checkStatus(obj.Status)}.");
                }
                if (obj is Window)
                {
                    obj.ShowPart();
                    Console.WriteLine($"{window++} - {checkStatus(obj.Status)}.");
                }
                if (obj is Roof)
                {
                    obj.ShowPart();
                    Console.WriteLine($" - {checkStatus(obj.Status)}.");
                }
                if (obj is Roof && obj.Status == true)
                    check = true;
            }
            if (check)
                Console.WriteLine("\nThe house is finished. Congratulation!");
            Console.WriteLine();
        }
    }
}
