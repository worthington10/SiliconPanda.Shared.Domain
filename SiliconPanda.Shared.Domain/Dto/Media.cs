using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Media : Content
    {
        [Required]
        [MaxLength(60)]
        public virtual string Title { get; set; }
    }
}
