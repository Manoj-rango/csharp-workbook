using System;

namespace myapp2
{
    class Program
    {
        static void Main()
        {
            var market = new DiscountPriceChecker();
            market.CalculateDiscount1(100,"DIWALI50");

            // var billing = new Billing();
            // billing.PrintBill();
        }
    }
}
