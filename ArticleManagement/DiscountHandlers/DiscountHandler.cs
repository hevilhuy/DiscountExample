using ArticleManagement.Models.Article;
using ArticleManagement.Models.Discount;
using System;

namespace ArticleManagement.DiscountHandlers
{
    public class DiscountHandler : IDiscountHandler
    { 
        private readonly Predicate<object> _canDiscounted;
        private readonly Action<IDiscount, IArticle> _discount;

        public DiscountHandler(Predicate<object> canDiscounted, Action<IDiscount, IArticle> discount)
        {
            _canDiscounted = canDiscounted;
            _discount = discount;
        }

        public bool CanDiscount(object parameter)
        {
            return _canDiscounted(parameter);
        }

        public void Discount(IDiscount discount, IArticle article)
        {
            bool canDiscount = _canDiscounted(_canDiscounted.Target);

            if (canDiscount)
            {
                _discount(discount, article);
            }
        }
    }
}
