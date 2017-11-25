using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Address : BaseEntity
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public virtual string AddressLine1 { get; set; }

        public virtual string AddressLine2 { get; set; }

        public virtual string AddressLine3 { get; set; }

        public virtual string Postcode { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public virtual string City { get; set; }

        public virtual string County { get; set; }

        [Required]
        public virtual string Country { get; set; }
    }
}
