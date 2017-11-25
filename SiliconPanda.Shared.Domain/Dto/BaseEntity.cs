using System;

namespace SiliconPanda.Shared.Domain.Dto
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedOnUtc = DateTime.UtcNow;
        }

        public Guid Id { get; set; }

        public DateTimeOffset ValidToUtc { get; set; }

        public DateTimeOffset ValidFromUtc { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedOnUtc { get; set; }

        public DateTimeOffset UpdatedOnUtc { get; set; }
    }
}
