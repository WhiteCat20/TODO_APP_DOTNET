using TodoApp.NET.Interfaces;
using TodoApp.NET.Models;

namespace TodoApp.NET.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly List<TodoItem> _todos = new List<TodoItem>();

        public void AddTodo(TodoItem item)
        {
            _todos.Add(item);
        }
        public void RemoveTodo(string title)
        {
            var item = _todos.FirstOrDefault(x => x.Title == title);
            if (item != null) {
                _todos.Remove(item);
            }
        }
        public List<TodoItem> GetAll()
        {
            return _todos;
        }

        public List<TodoItem> GetTodosByCategory(string category)
        {
            return _todos
                .Where(t => t.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }


    }
}
