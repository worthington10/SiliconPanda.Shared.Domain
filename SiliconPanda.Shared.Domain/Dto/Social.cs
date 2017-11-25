using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Social : BaseSiteEntity
    {
        public virtual SocialType Type { get; set; }

        public virtual string Handle { get; set; }

        public virtual string AppId { get; set; }

        public virtual string AppSecretId { get; set; }
    }
}
