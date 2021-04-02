using ArticleManagement.Models.Article;

namespace ArticleManagement.Util
{
    public class ArticleSalePriceCalculator
    {
        public static void CalculatePriceWithoutDiscount(ref IArticle article)
        {
            article.SalePrice = article.NetPrice * (article.VAT / 100 + 1) * (article.Margin / 100 + 1);
        }
    }
}
