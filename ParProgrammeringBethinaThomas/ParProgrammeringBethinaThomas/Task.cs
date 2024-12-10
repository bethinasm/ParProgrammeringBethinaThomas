namespace ParProgrammeringBethinaThomas
{
    internal class Task
    {
        public string taskName { get; set; }
        public string taskDate { get; set; }
        public string taskDescription { get; set; }


        public Task(string name, string date, string description)
        {
            taskName = name;
            taskDate = date;
            taskDescription = description;
        }
    }
}
