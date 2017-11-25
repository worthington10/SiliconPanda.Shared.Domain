using System.Collections.Generic;

namespace SiliconPanda.Shared.Domain.Dto
{
    public abstract class BaseSiteEntity : BaseEntity
    {
        protected BaseSiteEntity()
        {
            Sites = new HashSet<Site>();
        }

        public ICollection<Site> Sites { get; set; }
    }
}
