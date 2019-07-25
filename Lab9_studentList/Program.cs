using System;
using System.Collections.Generic;

namespace Lab9_studentList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string> {"Jon","Rick","Creed","Dexter","Morty"};
            List<string> studentHobby = new List<string> {"Sword fighting", "Dimension hopping", "Selling supplies from The Office", "Boating", "Stuff...computer stuff...yeah." };
            List<string> favFood = new List<string> {"Soup", "Beer", "Someone else's lunch", "Meat", "EyeHoles Cereal" };
            List<string> favColor = new List<string> {};

            WelcomeUser(students, "Yo! Select a student to learn about them!");
            int choice = GetUserInput("choose a number 1-5\n");
            DisplayInfo(students, choice);
            if(choice == 1)
            {
                Console.WriteLine($"What would you like to know about {students[choice-1]}?");
                int pick = GetUserInput($"1. Hobby \n2. Favorite Food\n");
                switch (pick)
                {
                    case 1:
                        DisplayInfo(studentHobby, choice);
                        break;
                    case 2:
                        DisplayInfo(favFood, choice);
                        break;
                    default:
                        GetUserInput("please select 1 or 2.");
                        break;
                }
            }
            else if(choice == 2)
            {
                int pick = GetUserInput($"1. Hobby \n2. Favorite Food\n");
                switch (pick)
                {
                    case 1:
                        DisplayInfo(studentHobby, choice);
                        break;
                    case 2:
                        DisplayInfo(favFood, choice);
                        break;
                    default:
                        GetUserInput("please select 1 or 2.");
                        break;
                }
            }
            else if(choice == 3)
            {
                int pick = GetUserInput($"1. Hobby \n2. Favorite Food\n");
                switch (pick)
                {
                    case 1:
                        DisplayInfo(studentHobby, choice);
                        break;
                    case 2:
                        DisplayInfo(favFood, choice);
                        break;
                    default:
                        GetUserInput("please select 1 or 2.");
                        break;
                }
            }
            else if(choice == 4)
            {
                int pick = GetUserInput($"1. Hobby \n2. Favorite Food\n");
                switch (pick)
                {
                    case 1:
                        DisplayInfo(studentHobby, choice);
                        break;
                    case 2:
                        DisplayInfo(favFood, choice);
                        break;
                    default:
                        GetUserInput("please select 1 or 2.");
                        break;
                }
            } 
            else if(choice == 5)
            {
                int pick = GetUserInput($"1. Hobby \n2. Favorite Food\n");
                switch (pick)
                {
                    case 1:
                        DisplayInfo(studentHobby, choice);
                        break;
                    case 2:
                        DisplayInfo(favFood, choice);
                        break;
                    default:
                        GetUserInput("please select 1 or 2.");
                        break;
                }
            }
            else
            {
                GetUserInput($"student number: {choice} is not available.  ");
            }
        }

        public static void WelcomeUser(List<string> list, string message)
        {
            Console.WriteLine(message);
            int count = 0;
            foreach (string student in list)
            {
                Console.WriteLine($"{count + 1}: {student}");
                count++;
            }
        }

        public static void DisplayInfo(List<string> list, int input)
        {
                Console.WriteLine(list[input-1]);
        }

        public static int GetUserInput(string message)
        {
            Console.WriteLine(message);
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
    }
}
