using TodoApp.NET.Interfaces;
using TodoApp.NET.Repositories;
using TodoApp.NET.Services;
using TodoApp.NET.UI;

ITodoRepository repository = new TodoRepository();
TodoService service = new TodoService(repository);
ConsoleUI ui = new ConsoleUI(service);

ui.runProgram();
