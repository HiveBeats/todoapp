using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.Domain.Models;

namespace Todo.Infrastructure.ModelBuilders
{
    public class TodoItemModelBuilder: ModelBuilderBase<TodoItem>
    {
        public TodoItemModelBuilder(EntityTypeBuilder<TodoItem> entity) : base(entity)
        {
        }

        public override void Build()
        {
            _entity.Property(x => x.Title).HasMaxLength(128);
            _entity.Property(x => x.Comment).HasMaxLength(512);
            _entity.HasIndex(x => x.IsDone);
        }
    }
}