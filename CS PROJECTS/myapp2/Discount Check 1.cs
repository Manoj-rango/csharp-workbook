using System;
using System.Linq;
using System.Collections.Generic;


/*
Input = (price, code) [float,string]
output = DiscountedPrice
*/

class DiscountChecker
{
    public void CalculateDiscount(float price,string code)
    {
        float Discount = 1;
        if(code == "qwerty")
        {
            Discount = 0.2f;
            //Console.WriteLine($"Discount price for {price} with {code} is" + "  " + price * Discount);
        }
        else if(code == "asdfgh")
        {
            Discount = 0.5f;
            //Console.WriteLine($"Discount price for {price} with {code} is" + "  " + price * Discount);
        }

        Console.WriteLine($"Discount price for {price} with {code} is" + "  " + price * Discount);
    }
    

}