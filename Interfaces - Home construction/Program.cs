using System;
using System.Collections.Generic;

namespace Interfaces___Home_construction
{
    class Program
    {
        static int Check(int answer)
        {
            while (answer < 1 || answer > 3)
            {
                Console.WriteLine("Your choice is not correct.");
                Console.WriteLine("You have to type 1(one), 2(two) or 3(three).");
                Console.Write("Make your choice here - ");
                answer = Convert.ToInt32(Console.ReadLine());
            }
            return answer;
        }
        static int Menu()
        {
            int answer;
            Console.WriteLine("What action do you want to do?");
            Console.WriteLine("1. Look into report about buiding processes.");
            Console.WriteLine("2. Build something.");
            Console.WriteLine("3. Exit from the program.");
            Console.Write("Type the correct answer here - ");
            answer = Convert.ToInt32(Console.ReadLine());
            return Check(answer);
        }
        static void Main(string[] args)
        {
            House house = new House();
            TeamLeader teamLeader = new TeamLeader("Petro");
            Team team = new Team("International IF build's team");
            Worker worker = new Worker();  // no any further information how to use worker in the program
            Console.WriteLine("Let's introduce the builders team.\n");
            teamLeader.ShowWorker();
            team.ShowWorker();
            do
            {
                switch (Menu())
                {
                    case 1:
                        teamLeader.BuildShow(house.GetList());
                        break;
                    case 2:
                        team.Build(house.GetList());
                        break;
                    case 3:
                        return;                
                }
            } while (true);
        }
    }
}
