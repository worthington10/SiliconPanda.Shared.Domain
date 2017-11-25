using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Template : BaseSiteEntity
    {
        [Required]
        [MaxLength(100)]
        public virtual string Title { get; set; }

        [MaxLength(250)]
        public virtual string IndexPath { get; set; }

        [MaxLength(250)]
        public virtual string LayoutPath { get; set; }

        [MaxLength(250)]
        public virtual string DetailsPath { get; set; }
    }
}
