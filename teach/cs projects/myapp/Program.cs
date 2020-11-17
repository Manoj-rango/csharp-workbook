using System;

namespace myapp
{
    class Program
    {
        static void Function2()
        {
            Console.WriteLine("Function2");
        }

        static void Function1()
        {
            Console.WriteLine("Function1");
            Function2();
        }

        //give discount if balance is above 10,000
        static float DiscountChecker(float balance, float price )
        {
            if(balance >= 10000)
            {
                float discountedPrice = (price * 0.90f);
                Console.WriteLine($"Discounted price for {price} is {discountedPrice}");
                return discountedPrice;
            }
            else
            {
                Console.WriteLine($"Your bank balance is less than 10,000");
                return 0;
            } 
        }


        static void Main()
        {
            Console.WriteLine("Entry point");
            DiscountChecker(50000, 200);
        }
    }
}
