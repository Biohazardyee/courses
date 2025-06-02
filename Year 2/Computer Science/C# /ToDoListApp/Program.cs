using System;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> ToDoList = new List<Task>();

            while (true)
            {
                Console.WriteLine("Welcome to your To Do List");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine();
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. See all tasks");
                Console.WriteLine("3. Mark a task as Complete");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Save tasks to a File");
                Console.WriteLine("6. Load Tasks from a File");
                Console.WriteLine("7. Leave");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Enter the task you need to do:");
                            string taskContentInput = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(taskContentInput))
                            {
                                Console.WriteLine("Please enter a valid name");
                                break;
                            }

                            Console.WriteLine("Enter the due date of the task");
                            string dueDateInput = Console.ReadLine();

                            Task task = new Task(taskContentInput, dueDateInput);
                            ToDoList.Add(task);

                            Console.WriteLine("New Task Created");

                            break;
                        }

                    case "2":
                        {
                            if (ToDoList.Count == 0)
                            {
                                Console.WriteLine("There are no tasks, yet");
                            }
                            else
                            {
                                foreach (Task task in ToDoList)
                                {
                                    task.DisplayList();
                                }
                            }
                            break;
                        }

                    case "7":
                        {
                            Console.WriteLine("Bye!");
                            return;
                        }
                }
            }

        }
    }
    class Task
    {
        string content;
        private static int nextId = 1;
        private int id;
        string dueDate;

        public string Content
        {
            get { return content; }
        }
        public int ID
        {
            get { return id; }
        }
        public string DueDate
        {
            get { return dueDate; }
        }


        public Task(string content, string dueDate)
        {
            this.content = content;
            this.dueDate = dueDate;
            this.id = nextId++;

        }
        public void DisplayList()
        {
            Console.WriteLine($"[{id}] {content} (Due: {dueDate})");
        }
    }
}