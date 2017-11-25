using FizzWare.NBuilder;
using FluentAssert;
using NUnit.Framework;
using SiliconPanda.Shared.Domain.Dro.Extensions;
using SiliconPanda.Shared.Domain.Dto;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Tests.Dto.Extensions.UserProfileExtensions
{
    [TestFixture]
    public class SetSocialTests
    {
        [Test]
        public void WhenSettingSocial_ShouldGetCorrectSocial([Values]SocialType type)
        {
            var user = Builder<UserProfile>.CreateNew().Build();
            var social = Builder<Social>.CreateNew().With(x => x.Type, type).Build();

            user.SetSocial(social);

            var socialReturn = user.GetSocial(type);
            socialReturn.ShouldBeEqualTo(social);
        }
    }
}
