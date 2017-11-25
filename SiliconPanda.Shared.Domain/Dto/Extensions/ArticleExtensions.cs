using System;
using System.Collections.Generic;
using System.Linq;

namespace SiliconPanda.Shared.Domain.Dto.Extensions
{
    public static class ArticleExtensions
    {
        public static void AddContributions(this Article article, IEnumerable<Contribution> contributions)
        {
            if (contributions == null)
                throw new ArgumentNullException(nameof(contributions));

            var contributionsToRemove = article.Contributions.Where(c => !contributions.Contains(c));
            foreach (var c in contributionsToRemove)
                article.Contributions.Remove(c);

            foreach (var c in contributions)
                if (!article.Contributions.Contains(c))
                    article.Contributions.Add(c);
        }

        public static void AddContent(this Article article, Content content)
        {
            if (!article.Content.Contains(content))
                article.Content.Add(content);
        }

        public static void AddContent(this Article article, IEnumerable<Content> content)
        {
            foreach (var c in content)
                article.AddContent(c);
        }
    }
}
