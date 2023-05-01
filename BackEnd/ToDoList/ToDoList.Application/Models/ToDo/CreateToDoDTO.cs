using System.ComponentModel.DataAnnotations;

namespace ToDoList.Application.Models.ToDo
{
    public class CreateTodoDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
