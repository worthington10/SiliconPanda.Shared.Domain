using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Type
{
    public enum SocialType
    {
        [Display(Description = "Facebook")]
        Facebook,

        [Display(Description = "Twitter")]
        Twitter,

        [Display(Description = "Pintrest")]
        Pintrest,

        [Display(Description = "MySpace")]
        Myspace,

        [Display(Description = "Instagram")]
        Instagram,

        [Display(Description = "LinkedIn")]
        LinkedIn,

        [Display(Description = "Google+")]
        GooglePlus,

        [Display(Description = "Tumblr")]
        Tumblr,

        [Display(Description = "Flickr")]
        Flickr,

        [Display(Description = "Google Analytics")]
        Gaq,

        [Display(Description = "Azure Analytics")]
        Azure,

        [Display(Description = "Email")]
        Email,

        [Display(Description = "Website")]
        Website,

        [Display(Description = "BeHance")]
        Behance,

        [Display(Description = "Digg")]
        Digg,

        [Display(Description = "Stumble Upon")]
        StumbleUpon,

        [Display(Description = "Rss")]
        Rss
    }
}
