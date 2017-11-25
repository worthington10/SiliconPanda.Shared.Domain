using System;
using System.Collections.Generic;
using System.Linq;

namespace SiliconPanda.Shared.Domain.Dto.Extensions
{
    public static class PlaylistExtensions
    {
        public static void SetContent(this Playlist playlist, IList<Content> content)
        {
            var audio = content.Where(c => c is Audio || c is EmbeddableMedia)
                .ToList();
            if (content.Count != audio.Count)
                throw new ArgumentOutOfRangeException("Non audio saved to playlist.");

            playlist.Content = audio;
        }

    }
}
