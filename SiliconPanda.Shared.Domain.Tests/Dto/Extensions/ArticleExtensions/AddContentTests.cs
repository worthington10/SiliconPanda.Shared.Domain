using System.Linq;
using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Dto.Extensions;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.ArticleExtensions
{
    [TestFixture]
    public class AddContentTests
    {
        [Test]
        public void WhenAddingContent_ShouldPopulateCollection()
        {
            var article = Builder<Article>.CreateNew().Build();
            var content = Builder<Content>.CreateNew().Build();

            article.AddContent(content);

            article.Content.First().ShouldBeEqualTo(content);
        }

        [Test]
        public void WhenAddingContent_ShouldNotAddDuplicate()
        {
            var content = Builder<Content>.CreateNew().Build();
            var article = Builder<Article>.CreateNew().Build();

            article.AddContent(content);
            article.AddContent(content);

            article.Content.Count.ShouldBeEqualTo(1);
            article.Content.First().ShouldBeEqualTo(content);
        }

        [Test]
        public void WhenAddingContentArray_ShouldPopulateCollection()
        {
            var article = Builder<Article>.CreateNew().Build();
            var content = Builder<Content>.CreateListOfSize(10).Build();

            article.AddContent(content);

            article.Content.ShouldBeEqualTo(content);
        }

        [Test]
        public void WhenAddingDuplicateContent_ShouldNotAddDuplicate()
        {
            var content = Builder<Content>.CreateListOfSize(1).Build();
            var article = Builder<Article>.CreateNew().Build();

            article.AddContent(content);
            article.AddContent(content);

            article.Content.Count.ShouldBeEqualTo(1);
            article.Content.ShouldBeEqualTo(content);
        }
    }
}
