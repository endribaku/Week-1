using System.ComponentModel;

class ToDoList
{
    public List<Task> tasks = new List<Task>();

    static void Main()
    {
        ToDoList list = new ToDoList();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Choose operation: ");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Display Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("0. Exit");

            string opCode = Console.ReadLine();

            switch (opCode)
            {
                case "0":
                    running = false;
                    break;
                case "1":
                    list.AddTask();
                    break;
                case "2":
                    list.DisplayTasks();
                    break;
                case "3":
                    list.CompleteTask();
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;

            }
        }
    }

    public void DisplayTasks()
    {
        int i = 1;
        foreach (Task task in tasks)
        {
            string status = task.IsCompleted ? "Completed" : "Not Completed";
            Console.WriteLine(i + " " + task.Description + " " + status);
            i++;
        }
    }

    public void CompleteTask()
    {
        this.DisplayTasks();
        Console.WriteLine("Choose Task by Number to Complete:");
        string taskChar = Console.ReadLine();
        int taskNum;
        bool isNumeric = int.TryParse(taskChar, out taskNum);

        if (!isNumeric)
        {
            Console.WriteLine("Invalid num");
        }
        else
        {
            int count = 1;
            foreach (Task task in tasks)
            {
                if (count == taskNum)
                {
                    task.IsCompleted = true;
                    break;
                }
                count++;
            }
        }
    }

    public void AddTask()
    {
        Console.WriteLine("Add description for task");
        string taskDesc = Console.ReadLine();
        this.tasks.Add(new Task(taskDesc));
    }
    

    
    

}

