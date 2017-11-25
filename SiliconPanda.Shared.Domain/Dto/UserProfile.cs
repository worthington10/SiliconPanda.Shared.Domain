using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
   public class UserProfile
    {
        public UserProfile()
        {
            Social = new HashSet<Social>();
        }

        [Required]
        [RegularExpression("^[a-zA-Z]+$")]
        public virtual string UserName { get; set; }

        [Required]
        [RegularExpression(@"[\s\w-']*")]
        public virtual string DisplayName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public virtual string Email { get; set; }

        [Required]
        public virtual string Description { get; set; }

        [DataType(DataType.Url)]
        public virtual string Website { get; set; }

        public virtual ICollection<Social> Social { get; set; }

        public virtual ICollection<AssetImage> Assets { get; set; }

        public virtual AssetImage Avatar { get { return Assets.LastOrDefault(a => a.AssetType == AssetType.Avatar); } }

        public virtual AssetImage Hero { get { return Assets.LastOrDefault(a => a.AssetType == AssetType.HeroContent); } }
    }
}
