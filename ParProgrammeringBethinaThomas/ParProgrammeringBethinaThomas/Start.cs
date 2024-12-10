namespace ParProgrammeringBethinaThomas
{
    internal class Start
    {

        private List<Task> toDoList = new List<Task>
        {
            new Task("Walk the dog"," 11.12 .24", "Go for a walk in the forest with the dog"),
            new Task("Feed the cats", "10.12.24", "Chicken or something")
        };

        // public void Menu()
        // {
        //     bool isRunning = true;

        //     do
        //     {
        //         Console.WriteLine("What would you like to do? \n[1] Add task \n[2] Delete task \n[3] Show all tasks \n[4] Exit program\n\n");
        //         var userInput = Console.ReadLine();

        //         switch (userInput)
        //         {
        //             case "1":
        //                 Console.Clear();
        //                 AddTask();
        //                 break;
        //             case "2":
        //                 Console.Clear();
        //                 DeleteTask();
        //                 break;
        //             case "3":
        //                 Console.Clear();
        //                 ShowAllTasks();
        //                 break;
        //             case "4":
        //                 isRunning = false;
        //                 Console.Clear();
        //                 Console.WriteLine("The program will now shut down.");
        //                 Thread.Sleep(1500);
        //                 return;
        //                 //Environment.Exit(0);
        //             default:
        //                 Console.Clear();
        //                 Console.WriteLine("Not a valid input, try again.");
        //                 Thread.Sleep(1500);
        //                 break;
        //         }
        //     } while (isRunning);
        // }

        public void AddTask()
        {
            Console.WriteLine("Write the name of you task:");
            var nameInput = Console.ReadLine();
            Console.WriteLine("Write the due date of your task:");
            var dateInput = Console.ReadLine();
            Console.WriteLine("Give a short description of you task:");
            var descriptionInput = Console.ReadLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            toDoList.Add(new Task(nameInput, dateInput, descriptionInput));
            Console.WriteLine("Your task is now added to your task list.\n");

        }

        public void DeleteTask()
        {
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"Index: [{i+1}]" +
                                  $"Name: {toDoList[i].taskName}" +
                                  $"Date: {toDoList[i].taskDate}" +
                                  $"Description {toDoList[i].taskDescription}");
            }

            Console.WriteLine("Write the number of the index for the task you want to delete");

            var input = Console.ReadLine();

            int inputToInt = Convert.ToInt32(input);

            int x = inputToInt - 1;

            toDoList.RemoveAt(x);
        }


        public void ShowAllTasks()
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
