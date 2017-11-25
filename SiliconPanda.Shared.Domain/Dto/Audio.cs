using System.ComponentModel.DataAnnotations;
using SiliconPanda.Shared.Domain.Convention;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Audio : Media, IPlayableMedia
    {
        [Required]
        [MaxLength(100)]
        public virtual string Artist { get; set; }

        public virtual int Duration { get; set; }

        [MaxLength(100)]
        public virtual string Path { get; set; }

        [MaxLength(20)]
        public virtual string ContentType { get; set; }
    }
}
