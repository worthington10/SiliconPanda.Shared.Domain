using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SiliconPanda.Shared.Domain.Convention;
using SiliconPanda.Shared.Domain.Dto.Extensions;
using SiliconPanda.Shared.Domain.Type;

namespace SiliconPanda.Shared.Domain.Dto
{
    public class Article : Content, IPublishable
    {
        public Article()
        {
            Content = new List<Content>();
            Contributions = new List<Contribution>();
            PublishDate = DateTime.Now.AddDays(7);
            FrontPage = true;
            SlugIsFullPath = false;
        }
        
        [StringLength(60, MinimumLength = 2)]
        public virtual string Title { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2)]
        public virtual string Summary { get; set; }

        [StringLength(80, MinimumLength = 3)]
        [RegularExpression(@"^[/a-z\d-–]*")]
        public virtual string Slug { get; set; }

        public virtual bool SlugIsFullPath { get; set; }

        public Guid? CoverImageId { get; set; }

        public virtual Image CoverImage { get; set; }

        public virtual DateTimeOffset? PublishDate { get; set; }

        public virtual bool Published { get; set; }

        public virtual bool FrontPage { get; set; }

        public virtual IList<Content> Content { get; internal set; }

        [Required]
        public virtual Tag Category
        {
            get => Tags.SingleOrDefault(c => c.TagType == TagType.Category);
            set => this.AddAndRemoveTags(new List<Tag> { value }, TagType.Category);
        }

        public virtual Tag PrimaryTag
        {
            get;
            set;
        }

        public virtual IEnumerable<Tag> Series
        {
            get => Tags.Where(c => c.TagType == TagType.Series);
            set => this.AddAndRemoveTags(value, TagType.Series);
        }

        public virtual IEnumerable<Tag> Keywords
        {
            get => Tags.Where(c => c.TagType == TagType.Keyword);
            set => this.AddAndRemoveTags(value, TagType.Keyword);
        }

        public virtual IEnumerable<File> Files
        {
            get { return Content.Where(c => c is File).Cast<File>(); }
        }

        public virtual IEnumerable<Image> Images
        {
            get { return Content.Where(c => c is Image).Cast<Image>(); }
        }

        public virtual IEnumerable<Video> Videos
        {
            get { return Content.Where(c => c is Video).Cast<Video>(); }
        }

        public virtual IEnumerable<Gallery> Galleries
        {
            get { return Content.Where(c => c is Gallery).Cast<Gallery>(); }
        }

        public virtual IEnumerable<Playlist> Playlists
        {
            get { return Content.Where(c => c is Playlist).Cast<Playlist>(); }
        }

        public virtual IEnumerable<Audio> Audio
        {
            get { return Content.Where(c => c is Audio).Cast<Audio>(); }
        }

        public virtual IEnumerable<EmbeddableMedia> EmbeddableMedia
        {
            get { return Content.Where(c => c is EmbeddableMedia).Cast<EmbeddableMedia>(); }
        }

        public virtual IList<Contribution> Contributions { get; set; }
    }
}
