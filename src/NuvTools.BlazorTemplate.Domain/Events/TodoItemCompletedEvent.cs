using NuvToolsBlazorTemplate.Domain.Common;
using NuvToolsBlazorTemplate.Domain.Entities;

namespace NuvToolsBlazorTemplate.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
