using System.Linq;
using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Dto.Extensions;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.ContentEnxtensions
{
    [TestFixture]
    public class MergeTagsTests
    {
        [Test]
        public void WhenMergingTags_ShouldNotRemoveOtherTagTypesAndMergeTagType()
        {
            var content = Builder<Content>.CreateNew().Build();
            var existingTags = Builder<Tag>.CreateListOfSize(22)
                .TheFirst(5)
                .With(x => x.TagType, TagType.Category)
                .TheNext(5)
                .With(x => x.TagType, TagType.Keyword)
                .TheNext(1)
                .With(x => x.TagType, TagType.Series)
                .TheFirst(5)
                .With(x => x.TagType, TagType.Category)
                .TheNext(5)
                .With(x => x.TagType, TagType.Keyword)
                .TheNext(1)
                .With(x => x.TagType, TagType.Series)
                .Build();
            
            content.MergeTags(existingTags.Take(11), TagType.Category);
            content.MergeTags(existingTags.Take(11), TagType.Keyword);
            content.MergeTags(existingTags.Take(11), TagType.Series);

            content.Tags.ShouldBeEqualTo(existingTags.Take(11));
            
            content.MergeTags(existingTags.Skip(11).Take(11), TagType.Category);
            content.MergeTags(existingTags.Skip(11).Take(11), TagType.Keyword);
            content.MergeTags(existingTags.Skip(11).Take(11), TagType.Series);
            
            content.Tags.ShouldBeEqualTo(existingTags.Skip(11).Take(11));
        }
    }
}
