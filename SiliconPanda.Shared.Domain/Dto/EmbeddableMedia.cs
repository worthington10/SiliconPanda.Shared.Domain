using System.ComponentModel.DataAnnotations;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class EmbeddableMedia : Content
    {
        public virtual MediaSource Source { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string RemoteId { get; set; }

        [MaxLength(2000)]
        public virtual string OfflineData { get; set; }
    }
}
