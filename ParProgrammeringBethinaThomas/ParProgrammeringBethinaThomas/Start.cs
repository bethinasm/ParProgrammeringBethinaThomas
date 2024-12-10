using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringBethinaThomas
{
    internal class Start
    {
        public void Menu()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("What would you like to do? \n[1] Add task \n[2] Delete task \n[3] Show all tasks \n[4] Exit program\n\n");
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        AddTask();
                        break;
                    case "2":
                        Console.Clear();
                        DeleteTask();
                        break;
                    case "3":
                        Console.Clear();
                        ShowAllTasks();
                        break;
                    case "4":
                        isRunning = false;
                        Console.Clear();
                        Console.WriteLine("The program will now shut down.");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Not a valid input, try again.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }

        private void AddTask()
        {
            Console.WriteLine("Write the name of you task:");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Write the due date of your task:");
            string dateInput = Console.ReadLine();
            Console.WriteLine("Give a short description of you task:");
            string descriptionInput = Console.ReadLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            toDoList.Add(new Task(nameInput, dateInput, descriptionInput));
            Console.WriteLine("Your task is now added to your task list.\n");

        }

        private void DeleteTask()
        {

        }

        private List<Task> toDoList = new List<Task>
            { 
                new Task("Walk the dog"," 11.12 .24", "Go for a walk in the forest with the dog"), 
                new Task("Feed the cats", "10.12.24", "Chicken or something")
            };

        private void ShowAllTasks()
        {
            Console.WriteLine("Showing all tasks: \n");
            foreach (var task in toDoList)
            {
                Console.WriteLine($"{task.taskName}\nDue Date: {task.taskDate}\nDescription: {task.taskDescription}");
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
