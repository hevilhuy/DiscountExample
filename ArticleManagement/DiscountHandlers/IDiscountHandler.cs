using ArticleManagement.Models.Article;
using ArticleManagement.Models.Discount;

#nullable enable

namespace ArticleManagement.DiscountHandlers
{
    public interface IDiscountHandler
    {
        public bool CanDiscount(object? parameter);
        public void Discount(IDiscount discount, IArticle article);
    }
}
