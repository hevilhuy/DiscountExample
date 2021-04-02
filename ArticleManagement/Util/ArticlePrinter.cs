using ArticleManagement.Models.Article;
using System;

namespace ArticleManagement.Util
{
    public static class ArticlePrinter
    {
        public static void PrintArticle(IArticle article)
        {
            Console.WriteLine($"Article name: {article.Name}, Sales price {article.SalePrice}");
        }
    }
}
