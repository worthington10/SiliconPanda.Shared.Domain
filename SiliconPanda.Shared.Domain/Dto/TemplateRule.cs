using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class TemplateRule : BaseEntity
    {
        public virtual ICollection<Tag> Tags { get; set; }

        public Guid? TemplateId { get; set; }

        [Required]
        public virtual Template Template { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public virtual string Title { get; set; }

        [StringLength(250, MinimumLength = 3)]
        public virtual string Description { get; set; }

        public virtual bool Home { get; set; }

        public virtual bool Article { get; set; }

        public Guid? HeaderImageId { get; set; }

        public virtual Image HeaderImage { get; set; }
    }

}
