namespace ArticleManagement.Models.Discount
{
    public class FirstBuyDiscount : IDiscount
    {
        public string Name { get; set; }
        public float Percentage { get; set; }
    }
}
