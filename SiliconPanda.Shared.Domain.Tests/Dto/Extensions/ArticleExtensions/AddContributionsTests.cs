using System.Linq;
using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Dto.Extensions;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.ArticleExtensions
{
    [TestFixture]
    public class AddContributionsTests
    {
        [Test]
        public void WhenAddingContent_ShouldPopulateCollection()
        {
            var article = Builder<Article>.CreateNew().Build();
            var content = Builder<Content>.CreateNew().Build();

            article.AddContent(content);

            article.Content.First().ShouldBeEqualTo(content);
        }
    }
}
