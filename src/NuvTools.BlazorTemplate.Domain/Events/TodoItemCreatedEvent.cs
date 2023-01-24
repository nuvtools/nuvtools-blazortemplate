using NuvToolsBlazorTemplate.Domain.Common;
using NuvToolsBlazorTemplate.Domain.Entities;

namespace NuvToolsBlazorTemplate.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
