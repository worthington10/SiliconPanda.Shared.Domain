using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Tag : BaseSiteEntity
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[/a-z\d-]*")]
        public virtual string Slug { get; set; }

        [StringLength(250)]
        public virtual string Description { get; set; }

        [Required]
        public virtual TagType TagType { get; set; }

        public virtual IEnumerable<TemplateRule> TemplateRules { get; protected set; }
    }
}
