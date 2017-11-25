using System;

namespace SiliconPanda.Shared.Domain.Convention
{
    public interface IPublishable
    {
        DateTimeOffset? PublishDate { get; set; }

        bool Published { get; set; }
    }
}
