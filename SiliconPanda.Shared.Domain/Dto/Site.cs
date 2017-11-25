using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Site
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Uri BaseUrl { get; set; }
        
        [Required]
        public string Description { get; set; }

        public string Keywords { get; set; }

        public ICollection<Social> Social { get; set; }
    }
}
