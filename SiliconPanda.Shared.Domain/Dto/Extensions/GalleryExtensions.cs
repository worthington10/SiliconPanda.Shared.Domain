using System;
using System.Collections.Generic;
using System.Linq;

namespace SiliconPanda.Shared.Domain.Dto.Extensions
{
    public static class GalleryExtensions
    {
        public static void AddImages(this Gallery gallery, IEnumerable<Image> images)
        {
            foreach (var i in images)
                gallery.Images.Add(i);
        }

        public static void SetContent(this Gallery gallery, IList<Content> content)
        {
            var images = content.OfType<Image>().ToList();

            if (images.Count != content.Count)
                throw new ArgumentException("Non image saved to gallery.");

            gallery.Images = new List<Image>(images);
        }
    }
}
