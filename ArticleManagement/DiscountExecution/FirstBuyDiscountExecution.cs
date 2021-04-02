using ArticleManagement.DiscountHandlers;
using ArticleManagement.Models.Article;
using ArticleManagement.Models.Discount;
using System;

namespace ArticleManagement.DiscountExecution
{
    public class FirstBuyDiscountExecution : BaseDiscountExecution, IDiscountExecution<FirstBuyDiscount>
    {
        public void ApplyDiscount(IDiscount discount, ref IArticle article)
        {
            ValidateInput(discount, article);
            string userInput = GetUserInput();
            var discountHandler = new DiscountHandler(r => userInput == "Yes", ExecuteDiscount);
            discountHandler.Discount(discount, article);
        }

        private static string GetUserInput()
        {
            Console.WriteLine("Is this your first purchase? (Yes/No)");
            return Console.ReadLine();
        }

        public override void ValidateInput(IDiscount discount, IArticle article)
        {
            base.ValidateInput(discount, article);

            if(discount is not FirstBuyDiscount)
            {
                throw new ArgumentException();
            }
        }
    }
}