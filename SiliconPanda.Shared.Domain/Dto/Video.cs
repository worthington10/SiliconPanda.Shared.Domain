using System;
using SiliconPanda.Shared.Domain.Convention;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Video : Media, IPublishable, IPlayableMedia
    {
        public DateTimeOffset? PublishDate { get; set; }

        public bool Published { get; set; }

        public string ContentType { get; set; }

        public string Path { get; set; }
    }
}
