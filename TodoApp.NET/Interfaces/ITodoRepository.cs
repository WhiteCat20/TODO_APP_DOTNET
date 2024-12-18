using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.NET.Models;

namespace TodoApp.NET.Interfaces
{
    public interface ITodoRepository
    {
        void AddTodo(TodoItem item);
        void RemoveTodo(string title);
        List<TodoItem> GetAll();
        List<TodoItem> GetTodosByCategory(string category);
    }
}
