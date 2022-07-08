using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.Domain.Models;

namespace Todo.Infrastructure.ModelBuilders
{
    public class UserModelBuilder: ModelBuilderBase<User>
    {
        public UserModelBuilder(EntityTypeBuilder<User> entity) : base(entity)
        {
        }

        public override void Build()
        {
            _entity.Property(x => x.Name).HasMaxLength(64);
            _entity.HasIndex(x => x.Name);
        }
    }
}