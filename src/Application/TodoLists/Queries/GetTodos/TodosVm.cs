﻿using clean_architecture.Application.Common.Models;

namespace clean_architecture.Application.TodoLists.Queries.GetTodos;

public class TodosVm
{
    public IReadOnlyCollection<LookupDto> PriorityLevels { get; init; } = Array.Empty<LookupDto>();

    public IReadOnlyCollection<TodoListDto> Lists { get; init; } = Array.Empty<TodoListDto>();
}
