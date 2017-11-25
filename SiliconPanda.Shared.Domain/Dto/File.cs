using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class File : Media
    {
        [Required]
        [MaxLength(5)]
        public virtual string Extension { get; set; }

        [Required]
        [MaxLength(50)]
        public virtual string ContentType { get; set; }

        [Required]
        public virtual long ContentLength { get; set; }

        public virtual bool IsText => ContentType.StartsWith("text/") || ContentType.EndsWith("javascript");

        public virtual bool IsImage => ContentType.StartsWith("image/");

        public virtual string FileName => Id + Extension;
    }
}
