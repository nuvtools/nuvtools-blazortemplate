using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NuvToolsBlazorTemplate.Domain.Entities;

namespace NuvToolsBlazorTemplate.Infrastructure.Data.Configurations;

public class TodoListConfiguration : IEntityTypeConfiguration<TodoList>
{
    public void Configure(EntityTypeBuilder<TodoList> builder)
    {
        builder.Property(t => t.Title)
           .HasMaxLength(280)
           .IsRequired();
    }
}
