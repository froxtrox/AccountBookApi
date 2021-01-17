using System;

namespace AccountBookApi.Domain
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; protected set; }
    }
}
