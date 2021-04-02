using ArticleManagement.DiscountExecution;
using ArticleManagement.Models.Article;
using ArticleManagement.Models.Discount;
using ArticleManagement.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArticleManagement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var listArticles = InitArticleData();
            var listAvailableDiscounts = InitAvailableDiscount();

            var _discountExecution = new PeriodDiscountExecution();
            var applyingDiscount = listAvailableDiscounts.First(d => d.Name == "Summer Discount");
            var article = listArticles.First();
            ArticleSalePriceCalculator.CalculatePriceWithoutDiscount(ref article);
            Console.WriteLine("===Article before discount===");
            ArticlePrinter.PrintArticle(article);
            Console.WriteLine("===Discount is being applied===");
            DiscountPrinter.PrintDiscount(applyingDiscount);
            Console.WriteLine("===Applying discount===");
            _discountExecution.ApplyDiscount(applyingDiscount, ref article);
            Console.WriteLine("===Article after discount===");
            ArticlePrinter.PrintArticle(article);
            
            Console.ReadLine();
        }

        private static List<IDiscount> InitAvailableDiscount()
        {
            return new List<IDiscount>()
            {
                new FirstBuyDiscount()
                {
                    Name = "First Buy",
                    Percentage = 50
                },
                new PeriodDiscount()
                {
                    Name = "Summer Discount",
                    Percentage = 20,
                    StartDate = new DateTime(2021, 4, 1),
                    EndDate = new DateTime(2021, 6 ,30)
                }
            };
        }

        private static List<IArticle> InitArticleData()
        {
            return new List<IArticle>()
            {
                new Article()
                {
                    Name = "Article1",
                    Margin = 10,
                    NetPrice = 50,
                    Slogan = "My slogan 1",
                    VAT = 20
                },
                new Article()
                {
                    Name = "Article2",
                    Margin = 20,
                    NetPrice = 60,
                    Slogan = "My slogan 2",
                    VAT = 30
                }
            };
        }
    }
}
