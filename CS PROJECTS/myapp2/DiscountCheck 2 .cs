using System;
using System.Linq;
using System.Collections.Generic;
/*Check for different discount codes
DIWALI50 - give 50% discount
HOLI20 - give 20% discount
SUMMERSALE - give 10% discount

Write a function that takes parameters of product price and disocunt code. Return discounted price
*/

/*
Input = (price, code) [float,string]
output = DiscountedPrice
*/class DiscountPriceChecker
{
    #region Class Variable
    Dictionary<string,float>  _discountDatabase = new Dictionary<string,float>();
    #endregion
    void Class_DiscountCodeDatabase()
    {
       _discountDatabase.Add("DIWALI50",12.3f);
       _discountDatabase.Add("SUMMER20",2.08f);
       _discountDatabase.Add("DUSERA25",87.8f);
    
    }

    public void CalculateDiscount1(float price, string code)
    {
        float discount = 1;
        if(code == "DIWALI50")
        {
            discount = 0.2f;
        }
        else if(code == "SUMMER20")
        {
            discount = 0.4f;
        }
        else if(code == "DUSERA25")
        {
            discount = 0.5f;
        }

        Console.WriteLine($"Discounted price for {price} with {code} is" + " " + price * discount);

    }

    public void CalculateDiscount2(float price, string code)
    {
        Class_DiscountCodeDatabase();
        if(CheckForDiscountCode(code))
        {
        var DiscountedPrice = (price * _discountDatabase[code]);
        Console.WriteLine($"Discounted price for {price} with {code} is" + " " + price * DiscountedPrice);
        }
    }
    bool CheckForDiscountCode(String code)
    {
        if (_discountDatabase.ContainsKey(code))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Discount code '" + code + " ' is invalid");
            return false;

        }
    }
}




   




