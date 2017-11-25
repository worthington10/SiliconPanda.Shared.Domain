using System;
using System.Collections.Generic;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Content : BaseSiteEntity
    {
        public Content()
        {
            Tags = new HashSet<Tag>();
            Articles = new HashSet<Article>();
        }

        public virtual Guid ContentId { get; set; }

        public int InternalId { get; set; }

        public virtual ICollection<Tag> Tags { get; internal set; }

        public virtual ICollection<Article> Articles { get; protected internal set; }
        
        public virtual bool IsVideo
        {
            get
            {
                if (this is Video)
                    return true;

                if (!(this is EmbeddableMedia)) return false;

                switch (((EmbeddableMedia)this).Source)
                {
                    case MediaSource.YouTube:
                    case MediaSource.Vimeo:
                        return true;
                    default:
                        return false;
                }
            }
        }

        public virtual bool IsAudio => this is Audio;

        public virtual bool IsEmbeddableAudioSoundCloudTrack => this is EmbeddableMedia && ((EmbeddableMedia)this).Source == MediaSource.SoundCloudTrack;

        public virtual bool IsEmbeddableAudioMixCloud => this is EmbeddableMedia && ((EmbeddableMedia)this).Source == MediaSource.MixCloud;

        public virtual bool IsEmbeddableAudio => IsEmbeddableAudioMixCloud && IsEmbeddableAudioSoundCloudTrack;

        public override bool Equals(object obj)
        {
            if (!(obj is Content c))
                return false;

            return ContentId == c.ContentId;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
