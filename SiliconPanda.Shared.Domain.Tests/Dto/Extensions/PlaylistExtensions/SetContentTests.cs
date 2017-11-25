using System;
using System.Collections.Generic;
using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Dto.Extensions;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.PlaylistExtensions
{
    [TestFixture]
    public class SetContentTests
    {
        [Test]
        public void WhenNotAllItemsAreAudio_ShouldThrow()
        {
            var playlist = Builder<Playlist>.CreateNew().Build();
            var content = new List<Content>
            {
                Builder<Audio>.CreateNew().Build(),
                Builder<EmbeddableMedia>.CreateNew().Build(),
                Builder<Image>.CreateNew().Build()
            };

            Assert.Throws<ArgumentOutOfRangeException>(() => playlist.SetContent(content));
        }

        [Test]
        public void WhenAddingAudio_ShouldAddToContent()
        {
            var playlist = Builder<Playlist>.CreateNew().Build();
            var content = new List<Content>
            {
                Builder<Audio>.CreateNew().Build(),
                Builder<EmbeddableMedia>.CreateNew().Build()
            };

            playlist.SetContent(content);

            playlist.Content.ShouldBeEqualTo(content);
        }
    }
}
