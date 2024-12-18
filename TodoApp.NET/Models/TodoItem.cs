using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.NET.Models
{
    public class TodoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool isCompleted { get; set; }

        public TodoItem(string title, string description, string category)
        {
            Title = title;
            Description = description;
            Category = category;
            isCompleted = false;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Category: {Category}, Completed: {isCompleted}";
        }
    }
}
