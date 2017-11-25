using System.Linq;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dro.Extensions
{
    public static class UserProfileExtensions
    {
        public static bool SocialHasData(this UserProfile user, SocialType type)
        {
            var socialMedia = user.Social.FirstOrDefault(a => a.Type == type);

            return socialMedia != null &&
                   (!string.IsNullOrEmpty(socialMedia.AppId) ||
                    !string.IsNullOrEmpty(socialMedia.AppSecretId) ||
                    !string.IsNullOrEmpty(socialMedia.Handle));
        }


        public static UserProfile SetSocial(this UserProfile user, Social social)
        {
            var old = user.Social.FirstOrDefault(s => s.Type == social.Type);

            if (old != null)
            {
                old.AppId = social.AppId;
                old.AppSecretId = social.AppSecretId;
                old.Handle = social.Handle;
            }
            else
            {
                user.Social.Add(social);
            }

            return user;
        }

        public static Social GetSocial(this UserProfile user, SocialType type)
        {
            return user.Social.FirstOrDefault(s => s.Type == type);
        }

    }
}
