using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Playlist : Content
    {
        public Playlist()
        {
            Content = new HashSet<Content>();
        }

        [Required]
        public virtual string Title { get; set; }

        public virtual ICollection<Content> Content
        {
            get;
            internal set;
        }
    }
}
