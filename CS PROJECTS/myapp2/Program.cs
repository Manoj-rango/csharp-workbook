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

            var person1 = new Bank("Harry ",984873211);
            person1.PrintDetails();

            
            Console.WriteLine("Name " + person1.Name );
            person1.Name = "mark";
            Console.WriteLine("After Change 1 " + person1.Name); 
            
            person1.Name = "abdes";
            Console.WriteLine("After Change 2 " + person1.Name);

        }
    }
}
