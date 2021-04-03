using ArticleManagement.Models.Article;
using ArticleManagement.Models.Discount;

namespace ArticleManagement.DiscountExecution
{
    public interface IDiscountExecution<T> where T : IDiscount
    {
        public void ApplyDiscount(IDiscount discount, ref IArticle article);
    }
}
