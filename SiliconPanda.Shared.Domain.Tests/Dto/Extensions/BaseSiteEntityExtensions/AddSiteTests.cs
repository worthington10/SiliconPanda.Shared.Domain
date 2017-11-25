using System.Linq;
using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Dto.Extensions;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.BaseSiteEntityExtensions
{
    [TestFixture]
    public class AddSiteTests
    {
        [Test]
        public void WhenAddingSite_ShouldAddToCollection()
        {
            var site = Builder<Site>.CreateNew().Build();
            var content = Builder<TestContent>.CreateNew().Build();

            content.AddSite(site);

            content.Sites.First().ShouldBeEqualTo(site);
        }

        [Test]
        public void WhenAddingSites_ShouldNotAddDuplicate()
        {
            var site = Builder<Site>.CreateNew().Build();
            var content = Builder<TestContent>.CreateNew().Build();

            content.AddSite(site);
            content.AddSite(site);

            content.Sites.Count.ShouldBeEqualTo(1);
            content.Sites.First().ShouldBeEqualTo(site);
        }

        [Test]
        public void WhenAddingSites_ShouldAddToCollection()
        {
            var site = Builder<Site>.CreateListOfSize(5).Build();
            var content = Builder<TestContent>.CreateNew().Build();

            content.AddSite(site);

            content.Sites.ShouldBeEqualTo(site);
        }

        [Test]
        public void WhenAddingDuplicateSiteToContent_ShouldNotAddDuplicate()
        {
            var site = Builder<Site>.CreateNew().Build();
            var content = Builder<TestContent>.CreateNew().Build();

            content.AddSite(site);
            content.AddSite(site);

            content.Sites.Count.ShouldBeEqualTo(1);
            content.Sites.First().ShouldBeEqualTo(site);
        }

        public class TestContent : BaseSiteEntity
        {
            
        }
    }
}
