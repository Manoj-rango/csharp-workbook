using System;
using System.Linq;
using System.Collections.Generic;

/*
input: Price, Code (float, string)
output: Disounted price (float)
*/
class DiscountChecker
{
    
    public void CalculateDiscount(float price, string code)
    {
        float discount = 1;
        if(code == "ABCD")
        {
            discount = 1f;
            
        }
        else if(code == "DIWALI50")
        {
            discount = 0.5f;
        }

        Console.WriteLine($"Discounted price for {price} with {code} is " + price * discount);
    }
}