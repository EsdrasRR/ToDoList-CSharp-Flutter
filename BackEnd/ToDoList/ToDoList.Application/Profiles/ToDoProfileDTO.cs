using ToDoList.Application.Models.ToDo;
using ToDoList.Application.Models;
using AutoMapper;
using ToDoList.Domain.Models;

namespace ToDoList.Application.Profiles
{
    public class TodoProfileDTO : Profile
    {
        public TodoProfileDTO()
        {
            CreateMap<BaseEntity, BaseEntityDTO>().ReverseMap();
            CreateMap<ToDo, ToDoDTO>().ReverseMap();
            CreateMap<ToDo, CreateTodoDTO>().ReverseMap();
        }
    }
}
