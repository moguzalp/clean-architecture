﻿using clean_architecture.Domain.Entities;

namespace clean_architecture.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord
{
    public string? Title { get; init; }

    public bool Done { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<TodoItem, TodoItemRecord>();
        }
    }
}
