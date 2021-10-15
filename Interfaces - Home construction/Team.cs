using System;
using System.Collections.Generic;

namespace Interfaces___Home_construction
{
    class Team : IWorker
    {
        string name;
        public Team(string name) { this.name = name; }
        int Check(int answer)
        {
            while (answer < 1 || answer > 5)
            {
                Console.WriteLine("Your choice is not correct.");
                Console.WriteLine("You have to type 1(one), 2(two), 3(three), 4 (four), 5 (five).");
                Console.Write("Make your choice here - ");
                answer = Convert.ToInt32(Console.ReadLine());
            }
            return answer;
        }
        int Menu()
        {
            int answer;
            Console.WriteLine("What part do you want to build?");
            Console.WriteLine("1. Basement, 2. Wall, 3. Door.");
            Console.WriteLine("4. Window, 5. Roof.");
            Console.Write("Type the correct answer here - ");
            answer = Convert.ToInt32(Console.ReadLine());
            return Check(answer);
        }
        public void ShowWorker()
        {
            Console.WriteLine("Hello guys. We are a build's team.");
            Console.WriteLine($"Our name - {name} and we will build a house.");
            Console.WriteLine("Of course if it is possible.");
            Console.WriteLine("We will help you with builds the dream house.\n");
        }
        public void Build(List<IPart> obj)
        {
            bool check = false;
            int qtyWall = 1, qtyWindow = 1;
            Console.WriteLine();
            switch (Menu())
            {
                case 1:
                    foreach (var part in obj)
                    {
                        if (part is Basement)
                        {
                            if (part.Status == false)
                            {
                                part.Status = true;
                                Console.WriteLine($"\nThe team built a {part.ShowPart()}.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"\nThe {part.ShowPart()} of the house could not be build.");
                                Console.WriteLine("Because it is already built");
                                Console.WriteLine("Check it in the report.");
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    int wallsBuilt = 0;
                    foreach (var part in obj)
                    {
                        if (part is Basement && part.Status == true)
                            check = true;
                        else if (part is Basement && part.Status == false)
                        {
                            check = false;
                            break;
                        }
                        if (part is Wall && part.Status == true)
                            wallsBuilt++;
                    }
                    if (check && wallsBuilt < 4)
                    {
                        foreach (var part in obj)
                        {
                            if (part is Wall)
                            {
                                if (part.Status == false)
                                {
                                    part.Status = true;
                                    Console.WriteLine($"\nThe team built a {part.ShowPart()} {qtyWall}.");
                                    break;
                                }
                                qtyWall++;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThe wall of the house could not be build.");
                        Console.WriteLine("Because they are already built or basement is absent.");
                        Console.WriteLine("Check it in the report.");
                        break;
                    }
                    break;
                case 3:
                    qtyWall = 0;
                    foreach (var part in obj)
                    {
                        if (part is Wall && part.Status == true)
                            qtyWall++;
                        if (part is Door && part.Status == false)
                            check = true;
                    }
                    if (check && qtyWall == 4)
                        foreach (var part in obj)
                        {
                            if (part is Door)
                            {
                                if (part.Status == false)
                                {
                                    part.Status = true;
                                    Console.WriteLine($"\nThe team built a {part.ShowPart()}.");
                                    break;
                                }
                            }
                        }
                    else
                    {
                        Console.WriteLine("\nThe door of the house could not be build.");
                        Console.WriteLine("Because it is already built or not all walls are present.");
                        Console.WriteLine("Check it in the report.");
                        break;
                    }
                    break;
                case 4:
                    int windowsBuilt = 0;
                    foreach (var part in obj)
                    {
                        if (part is Door && part.Status == true)
                            check = true;
                        else if (part is Door && part.Status == false)
                        {
                            check = false;
                            break;
                        }
                        if (part is Window && part.Status == true)
                            windowsBuilt++;
                    }
                    if (check && windowsBuilt < 4)
                    {
                        foreach (var part in obj)
                        {
                            if (part is Window)
                            {
                                if (part.Status == false)
                                {
                                    part.Status = true;
                                    Console.WriteLine($"\nThe team built {part.ShowPart()} {qtyWindow}.");
                                    break;
                                }
                                qtyWindow++;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThe window of the house could not be build.");
                        Console.WriteLine("Because they are already built or door is absent.");
                        Console.WriteLine("Check it in the report.");
                        break;
                    }
                    break;
                case 5:
                    qtyWindow = 0;
                    foreach (var part in obj)
                    {
                        if (part is Window && part.Status == true)
                            qtyWindow++;
                        if (part is Roof && part.Status == false)
                            check = true;
                    }
                    if (check && qtyWindow == 4)
                        foreach (var part in obj)
                        {
                            if (part is Roof)
                            {
                                if (part.Status == false)
                                {
                                    part.Status = true;
                                    Console.WriteLine($"\nThe team built {part.ShowPart()}.");
                                    Console.WriteLine("The house is finished. Check it in the report.");
                                    break;
                                }
                            }
                        }
                    else
                    {
                        Console.WriteLine("\nThe roof of the house could not be build.");
                        Console.WriteLine("Because it is already built or not all windows are present.");
                        Console.WriteLine("Check it in the report.");
                        break;
                    }
                    break;
            }
            Console.WriteLine();
        }
    }
}
