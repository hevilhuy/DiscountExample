using ArticleManagement.DiscountHandlers;
using ArticleManagement.Models.Article;
using ArticleManagement.Models.Discount;
using System;

namespace ArticleManagement.DiscountExecution
{
    public class PeriodDiscountExecution : BaseDiscountExecution, IDiscountExecution<PeriodDiscount>
    {
        public void ApplyDiscount(IDiscount discount, ref IArticle article)
        {
            ValidateInput(discount, article);
            var castedDiscount = discount as PeriodDiscount;
            var discountHandler = new DiscountHandler(r => IsBetweenDate(castedDiscount.StartDate, castedDiscount.EndDate), ExecuteDiscount);
            discountHandler.Discount(discount, article);
        }

        private bool IsBetweenDate(DateTime startDate, DateTime endDate)
        {
            var today = DateTime.Now;
            bool result = today.Ticks > startDate.Ticks && today.Ticks < endDate.Ticks;

            return result;
        }

        public override void ValidateInput(IDiscount discount, IArticle article)
        {
            base.ValidateInput(discount, article);

            if (discount is not PeriodDiscount)
            {
                throw new ArgumentException();
            }
        }
    }
}
