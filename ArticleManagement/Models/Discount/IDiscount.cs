namespace ArticleManagement.Models.Discount
{
    public interface IDiscount
    {
        public string Name { get; set; }
        public float Percentage { get; set; }
    }
}
