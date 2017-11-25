using System.Collections.Generic;

namespace SiliconPanda.Shared.Domain.Dto.Extensions
{
    public static class BaseSiteEntityExtensions
    {
        public static void AddSite(this BaseSiteEntity baseSiteEntity, IEnumerable<Site> sites)
        {
            foreach (var s in sites)
            {
                baseSiteEntity.AddSite(s);
            }
        }

        public static void AddSite(this BaseSiteEntity baseSiteEntity, Site site)
        {
            if (!baseSiteEntity.Sites.Contains(site))
                baseSiteEntity.Sites.Add(site);
        }
    }
}
