using ParProgrammeringBethinaThomas;

class Program
{
    static void Main()
    {

        Console.WriteLine("Par Programmering Oppgave\n");
        Console.WriteLine("TO DO APP\n");
        /*
            Konsollbasert ToDo liste
            Lag en todo app! Du skal kunne legge til oppgaver, slette dem og gå inn på en task for å se beskrivelse eller flere detaljer
         */

        Start start = new Start();


        do
        {
            Console.WriteLine("What would you like to do? \n[1] Add task \n[2] Delete task \n[3] Show all tasks \n[4] Exit program\n\n");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    start.AddTask();
                    break;
                case "2":
                    Console.Clear();
                    start.DeleteTask();
                    break;
                case "3":
                    Console.Clear();
                    start.ShowAllTasks();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("The program will now shut down.");
                    Thread.Sleep(1500);
                    return;
                //Environment.Exit(0);
                default:
                    Console.Clear();
                    Console.WriteLine("Not a valid input, try again.");
                    Thread.Sleep(1500);
                    break;
            }
        } while (true);
    }

}


