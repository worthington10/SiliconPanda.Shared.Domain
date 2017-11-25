using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SiliconPanda.Shared.Domain.Dto.Extensions;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Gallery : Content
    {
        public Gallery()
        {
            Images = new List<Image>();
        }

        [Required]
        public virtual string Title { get; set; }

        [Required]
        public virtual string Summary { get; set; }

        [Required]
        public virtual GalleryType Type { get; set; }

        [Required]
        public virtual Tag Category
        {
            get => Tags.SingleOrDefault(c => c.TagType == TagType.Category);
            set => this.AddAndRemoveTags(new List<Tag> { value }, TagType.Category);
        }

        public virtual IList<Image> Images
        {
            get;
            internal set;
        }
    }
}
