using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.NET.Services;

namespace TodoApp.NET.UI
{
    public class ConsoleUI
    {
        private readonly TodoService service;

        public ConsoleUI(TodoService service)
        {
            this.service = service;
        }

        public void runProgram()
        {
            while (true)
            {
                Console.WriteLine("\nTodo List App");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Remove Todo");
                Console.WriteLine("3. Display Todos by Category");
                Console.WriteLine("4. Display All Todos");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Title: ");
                        var title = Console.ReadLine();
                        Console.Write("Description: ");
                        var desc = Console.ReadLine();
                        Console.Write("Category: ");
                        var category = Console.ReadLine();
                        service.AddNewTodo(title, desc, category);
                        break;
                    case "2":
                        Console.Write("Title to remove: ");
                        var titleToRemove = Console.ReadLine();
                        service.DeleteTodo(titleToRemove);
                        break;
                    case "3":
                        Console.Write("Category: ");
                        var cat = Console.ReadLine();
                        service.DisplayTodosByCategory(cat);
                        break;
                    case "4":
                        service.DisplayAllTodos();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
