using ArticleManagement.Models.Discount;
using System;

namespace ArticleManagement.Util
{
    public static class DiscountPrinter
    {
        public static void PrintDiscount(IDiscount discount)
        {
            Console.WriteLine($"Discount: {discount.Name}, Percentage: {discount.Percentage}");
        }

        public static void PrintDiscount(PeriodDiscount discount)
        {
            PrintDiscount(discount);
            Console.Write($", Start Date: {discount.StartDate:yyyy-mm-dd}, End Date: {discount.EndDate:yyyy-mm-dd}");
        }
    }
}
