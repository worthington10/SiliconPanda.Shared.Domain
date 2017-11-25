using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SiliconPanda.Shared.Domain.Convention;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Image : File, IDisplayContent
    {
        public Image()
        {
            Crops = new HashSet<ImageCrop>();
        }

        public Image(File file)
            : this()
        {
            Title = file.Title;
            ContentLength = file.ContentLength;
            ContentType = file.ContentType;
            InternalId = file.InternalId;
            Extension = file.Extension;
        }
        
        [StringLength(255, MinimumLength = 2)]
        public virtual string Caption { get; set; }

        [StringLength(255, MinimumLength = 2)]
        public virtual string Credit { get; set; }

        public virtual string AlternateText => Title;

        public virtual short Width { get; set; }

        public virtual short Height { get; set; }

        public virtual ICollection<ImageCrop> Crops { get; protected set; }

        public virtual string Version { get; set; }

        public virtual float AspectRatio => Width / Height;
    }
}
