using System;
using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Dto.Extensions;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.ImageExtenstions
{
    [TestFixture]
    public class GetDefaultImageCropTests
    {
        [Test]
        public void WhenImageIsEmpty_ShouldThrow()
        {
            Assert.Throws<ArgumentNullException>(() => ImageExtensions.GetDefaultImageCrop(null, CropType.Asset, 1, 1));
        }

        [Test]
        public void WhenCreatingCrop_ShouldHaveCorrectAspectRation()
        {
            var image = Builder<Image>.CreateNew().With(x => x.Height, (short)453).With(x => x.Width, (short)987).Build();

            var crop = image.GetDefaultImageCrop(CropType.Asset, 1234, 321);

            crop.Image.ShouldBeEqualTo(image);

           crop.AspectRatio.ShouldBeEqualTo(3);
            crop.CropX.ShouldBeEqualTo((short)0);
            crop.CropY.ShouldBeEqualTo((short)0);
            crop.Height.ShouldBeEqualTo((short)256);
            crop.Width.ShouldBeEqualTo((short)987);
            crop.Type.ShouldBeEqualTo(CropType.Asset);
        }

        [Test]
        public void WhenCreatingCropAndWidthIsTooSmall_ShouldUseOriginalWidth()
        {
            var image = Builder<Image>.CreateNew().With(x => x.Height, (short)453).With(x => x.Width, (short)987).Build();

            var crop = image.GetDefaultImageCrop(CropType.Asset, 1234, 321);

            crop.Image.ShouldBeEqualTo(image);
                      crop.AspectRatio.ShouldBeEqualTo(3);
            crop.CropX.ShouldBeEqualTo((short)0);
            crop.CropY.ShouldBeEqualTo((short)0);
            crop.Height.ShouldBeEqualTo((short)256);
            crop.Width.ShouldBeEqualTo((short)987);
            crop.Type.ShouldBeEqualTo(CropType.Asset);
        }
    }
}
