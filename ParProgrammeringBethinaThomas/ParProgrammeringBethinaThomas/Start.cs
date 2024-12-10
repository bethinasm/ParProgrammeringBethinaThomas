namespace ParProgrammeringBethinaThomas
{
    internal class Start
    {

        private List<Task> toDoList = new List<Task>
        {
            new Task("Walk the dog","11.12.24", "In the forest."),
            new Task("Feed the cats", "10.12.24", "Chicken or something.")
        };


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
                Console.WriteLine($"Index: [{i+1}]\n" +
                                  $"Name: {toDoList[i].taskName}\n" +
                                  $"Date: {toDoList[i].taskDate}\n" +
                                  $"Description: {toDoList[i].taskDescription}\n");
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("Write the number of the index for the task you want to delete.");

            var input = Console.ReadLine();

            int inputToInt = Convert.ToInt32(input);

            int x = inputToInt - 1;

            toDoList.RemoveAt(x);
            Console.WriteLine("The task is now deleted.\n");
            Thread.Sleep(1500);
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
