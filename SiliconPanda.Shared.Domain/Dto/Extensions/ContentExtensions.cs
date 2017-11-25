using System;
using System.Collections.Generic;
using System.Linq;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto.Extensions
{
    public static class ContentExtensions
    {
        public static void MergeTags(this Content content, IEnumerable<Tag> tags, TagType tagType)
        {
            tags = tags.Where(t => t?.TagType == tagType);
            var tagList = content.Tags.Where(t => t.TagType != tagType).ToList();
            tagList.AddRange(tags);
            content.Tags = tagList;
        }
    }
}
