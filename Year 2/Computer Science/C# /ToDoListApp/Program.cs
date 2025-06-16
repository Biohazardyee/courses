using System;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string SaveFilePath = "saveFile.txt";
            List<TaskItem> tasks = new List<TaskItem>();

            if (File.Exists(SaveFilePath))
            {
                string[] savedTasks = File.ReadAllLines(SaveFilePath);
                foreach (var line in savedTasks)
                {
                    // Assuming format: [X] description or [ ] description
                    bool isCompleted = line.StartsWith("[X]");
                    string description = line.Length > 4 ? line.Substring(4) : "";
                    tasks.Add(new TaskItem(description, isCompleted));
                }
            }
            while (true)
            {
                Console.WriteLine("Welcome to your To Do List");
                Console.WriteLine();

                Console.WriteLine("Please choose what you want to do");
                Console.WriteLine();

                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark as complete");
                Console.WriteLine("4. Delete task");
                Console.WriteLine("5. Exit");

                int choice;
                string? input = Console.ReadLine();

                if (input == null || !int.TryParse(input, out choice))
                {
                    Console.Clear();
                    Console.WriteLine("Enter a valid choice");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Create a new task");
                        Console.WriteLine();

                        Console.WriteLine("Enter the task description");
                        string? taskInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(taskInput))
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a valid task");
                            continue;
                        }
                        Console.Clear();
                        tasks.Add(new TaskItem(taskInput, false));
                        Console.WriteLine($"You task {taskInput} has been added");
                        File.WriteAllLines(SaveFilePath, tasks.Select(task => task.ToString()));
                        Console.WriteLine("Tasks have been saved to file.");
                        break;

                    case 2:

                        Console.Clear();
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            foreach (var task in tasks)
                            {
                                Console.WriteLine(task);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case 3:

                        Console.Clear();

                        for (int i = 0; i < tasks.Count; i++)
                        {
                            string status = tasks[i].IsCompleted ? "[X]" : "[ ]";
                            string message = $"{i + 1}. {status} {tasks[i].Description}";
                            Console.WriteLine(message);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Enter the ID of the task you wish to mark as completed.");
                        Console.WriteLine("Or press 'Q' to leave");
                        string? input2 = Console.ReadLine();
                        if (!string.IsNullOrEmpty(input2) && input2.Trim().Equals("Q", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Clear();
                            break;
                        }
                        int choice2;
                        if (input2 == null || !int.TryParse(input2, out choice2) || choice2 < 1 || choice2 > tasks.Count)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a valid ID");
                            continue;
                        }
                        else
                        {
                            var selectedTask = tasks[choice2 - 1];
                            selectedTask.IsCompleted = !selectedTask.IsCompleted;
                            Console.Clear();
                            if (selectedTask.IsCompleted == true)
                            {
                                Console.WriteLine($"Your task \"{selectedTask.Description}\" is marked as complete.");
                            }
                            else
                            {
                                Console.WriteLine($"Your task \"{selectedTask.Description}\" is marked as to do.");
                            }
                            Console.WriteLine("Saved");
                            Console.WriteLine();
                            File.WriteAllLines(SaveFilePath, tasks.Select(task => task.ToString()));

                        }
                        break;

                    case 4:

                        Console.Clear();

                        for (int i = 0; i < tasks.Count; i++)
                        {
                            string message = $"{i + 1}. {tasks[i].Description}";
                            Console.WriteLine(message);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Enter the ID of the task you wish to delete.");
                        Console.WriteLine("Or press 'Q' to leave");

                        string? input3 = Console.ReadLine();
                        if (!string.IsNullOrEmpty(input3) && input3.Trim().Equals("Q", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Clear();
                            break;
                        }

                        int choice3;
                        if (input3 == null || !int.TryParse(input3, out choice3) || choice3 < 1 || choice3 > tasks.Count)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a valid ID");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            var selectedTask = tasks[choice3 - 1];
                            Console.WriteLine($"Your task \"{selectedTask.Description}\" has been removed");
                            tasks.Remove(selectedTask);
                            File.WriteAllLines(SaveFilePath, tasks.Select(task => task.ToString()));
                            Console.WriteLine("Saved");
                            Console.WriteLine();
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Bye");
                        return;
                }

            }
        }
    }
    public class TaskItem
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string description, bool isCompleted)
        {
            Description = description;
            IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return $"{(IsCompleted ? "[X]" : "[ ]")} {Description}";
        }

    }
}