using System;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class AssetImage : BaseSiteEntity
    {
        public AssetType AssetType { get; set; }

        public Guid? ImageId { get; set; }

        public Image Image { get; set; }
    }
}
