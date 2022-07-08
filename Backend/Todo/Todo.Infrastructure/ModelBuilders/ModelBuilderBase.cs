using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Todo.Infrastructure.ModelBuilders
{
    public abstract class ModelBuilderBase<T> where T: class
    {
        protected EntityTypeBuilder<T> _entity;

        protected ModelBuilderBase(EntityTypeBuilder<T> entity)
        {
            _entity = entity;
        }
        public abstract void Build();
    }
}