using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Dto.Extensions;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.ImageExtenstions
{
    [TestFixture]
    public class HasCropTests
    {
        [Test]
        public void WhenImageHasCrop_ShouldReturnTrue()
        {
            var imageCrop = Builder<ImageCrop>.CreateNew().With(x => x.Type, CropType.Hero).Build();
        
            var image = Builder<Image>.CreateNew().Build();
            image.Crops.Add(imageCrop);

            image.HasCrop(CropType.Hero).ShouldBeTrue();
        }

        [Test]
        public void WhenImageDoesNotHaveCrop_ShouldReturnFalse()
        {
            var imageCrop = Builder<ImageCrop>.CreateNew().With(x => x.Type, CropType.Hero).Build();

            var image = Builder<Image>.CreateNew().Build();
            image.Crops.Add(imageCrop);

            image.HasCrop(CropType.Asset).ShouldBeFalse();
        }

        [Test]
        public void WhenImageCropIsNull_ShouldReturnFalse()
        {
            var image = Builder<Image>.CreateNew().Build();

            image.HasCrop(CropType.Asset).ShouldBeFalse();
        } 
    }
}
