using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.NET.Interfaces;
using TodoApp.NET.Models;

namespace TodoApp.NET.Services
{
    public class TodoService
    {
        private readonly ITodoRepository repository;

        public TodoService(ITodoRepository repository)
        {
            this.repository = repository;
        }

        public void AddNewTodo(string title, string description, string category)
        {
            var newItem = new TodoItem(title, description, category);
            repository.AddTodo(newItem);
        }

        public void DeleteTodo(string title)
        {
            repository.RemoveTodo(title);
        }

        public void DisplayTodosByCategory(string category)
        {
            var todos = repository.GetTodosByCategory(category);
            foreach (var todosItem in todos)
            {
                Console.WriteLine(todosItem);
            }
        }

        public void DisplayAllTodos()
        {
            var todos = repository.GetAll();
            foreach (var todosItem in todos) { 
                Console.WriteLine(todosItem);
            }
        }
    }
}
