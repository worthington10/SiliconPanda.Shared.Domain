using System;
using System.Linq;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto.Extensions
{
    public static class ImageExtensions
    {
        public static ImageCrop GetDefaultImageCrop(this Image image, CropType type, short aspectRatioX, short aspectRatioY)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image));

            var crop = GetDefaultImageCrop(type, aspectRatioX, aspectRatioY, image.Width, image.Height);
            crop.Image = image;
            return crop;
        }

        public static ImageCrop GetCrop(this Image image, CropType type)
        {
            return image.Crops.LastOrDefault(a => a.Type == type); ;
        }

        public static bool HasCrop(this Image image, CropType type)
        {
            return image.GetCrop(type) != null;
        }

        public static void ReplaceCrop(this Image image, CropType type, short x, short y, short width, short height)
        {
            if (x < 0) x = 0;
            if (y < 0) y = 0;

            if (width <= 0) throw new ArgumentOutOfRangeException(nameof(width));
            if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height));

            var crop = image.GetCrop(type) ?? new ImageCrop(image, type);

            crop.CropX = x;
            crop.CropY = y;
            crop.Width = width;
            crop.Height = height;

            if (!image.HasCrop(type))
                image.Crops.Add(crop);
        }

        private static ImageCrop GetDefaultImageCrop(CropType type, short aspectRatioX, short aspectRatioY, short imageWidth, short imageHeight)
        {
            var crop = new ImageCrop(type) { CropX = 0, CropY = 0 };

            if (imageWidth / (float)aspectRatioX >= imageHeight / (float)aspectRatioY)
            {
                crop.Width = (short)((float)aspectRatioX * imageHeight / aspectRatioY);
                crop.Height = imageHeight;
            }
            else
            {
                crop.Width = imageWidth;
                crop.Height = (short)((float)aspectRatioY * imageWidth / aspectRatioX);
            }

            return crop;
        }

    }
}
