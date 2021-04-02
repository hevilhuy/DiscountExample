namespace ArticleManagement.Models.Article
{
    public class Article : IArticle
    {
        public string Name { get; set; }
        public string Slogan { get; set; }
        public double NetPrice { get; set; }
        public double SalePrice { get; set; }
        public float VAT { get; set; }
        public float Margin { get; set; }
    }
}
