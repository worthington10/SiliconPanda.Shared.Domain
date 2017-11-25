using System;
using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Contribution : BaseEntity
    {
        [Required]
        public virtual string RoleName { get; set; }

        public Guid UserId { get; set; }

        [Required]
        public virtual UserProfile UserProfile { get; set; }
    }
}
