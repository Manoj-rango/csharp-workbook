using System;

namespace myapp2
{
    class Program
    {
        static void Main()
        {
            // var market = new DiscountPriceChecker();
            // market.CalculateDiscount1(100,"DIWALI50");

            // var billing = new Billing2();
            // billing.C_billing2();

            var AccountHolder = new Bank("Harry ",984873211);
            AccountHolder.PrintDetails(); 
        }
    }
}
