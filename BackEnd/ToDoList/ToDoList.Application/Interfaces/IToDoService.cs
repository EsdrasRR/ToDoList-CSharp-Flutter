using ToDoList.Application.Models.ToDo;

namespace ToDoList.Application.Interfaces
{
    public interface IToDoService
    {
        public Task<List<ToDoDTO>> GetToDosAsync(int? userId);
        public ToDoDTO UpdateToDo(ToDoDTO todo);
        public ToDoDTO CreateToDo(CreateTodoDTO todo);
        public void DeleteToDo(int? userId, int todoId);

    }
}
