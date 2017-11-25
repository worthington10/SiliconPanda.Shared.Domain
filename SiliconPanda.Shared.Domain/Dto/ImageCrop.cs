using System;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public sealed class ImageCrop : BaseEntity
    {
        public ImageCrop() : this(CropType.None)
        {
        }

        public ImageCrop(CropType type) : this(null, type)
        {
        }

        public ImageCrop(Image image, CropType type)
        {
            Image = image;
            Type = type;
        }

        public Image Image { get; set; }

        public float AspectRatio => Width / Height;

        public short CropX { get; set; }

        public short CropY { get; set; }

        public short Width { get; set; }

        public CropType Type { get; set; }

        public short Height { get; set; }
    }
}
