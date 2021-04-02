using ArticleManagement.DiscountHandlers;
using ArticleManagement.Models.Article;
using ArticleManagement.Models.Discount;
using System;

namespace ArticleManagement.DiscountExecution
{
    public abstract class BaseDiscountExecution
    {
        public virtual void ExecuteDiscount(IDiscount discount, IArticle article)
        {
            article.SalePrice = Math.Max(article.SalePrice * (discount.Percentage / 100), article.NetPrice);
        }

        public virtual void ValidateInput(IDiscount discount, IArticle article)
        {
            if (discount is null)
            {
                throw new ArgumentNullException(nameof(discount));
            }

            if (article is null)
            {
                throw new ArgumentNullException(nameof(article));
            }
        }
    }
}
