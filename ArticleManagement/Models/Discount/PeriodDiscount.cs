using System;

namespace ArticleManagement.Models.Discount
{
    public class PeriodDiscount : IDiscount
    {
        public float Percentage { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
