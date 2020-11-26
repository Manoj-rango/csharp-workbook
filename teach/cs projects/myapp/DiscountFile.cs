using System;
using System.Linq;
using System.Collections.Generic;

/*
input: Price, Code (float, string)
output: Disounted price (float)
*/
class DiscountChecker
{

    #region class variable
    Dictionary<string, float> _discountDatabase = new Dictionary<string, float>();
    #endregion


    void CreateDiscountDatabase()
    {
        _discountDatabase.Add("DIWALI50", 0.5f);
        _discountDatabase.Add("SUMMER20", 0.8f);
        _discountDatabase.Add("DUSERA25", 0.75f);
        _discountDatabase.Add("GANESH15", 0.85f);
    }
    
    public void CalculateDiscount1(float price, string code)
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

    public void CalculateDiscount2(float price, string code)
    {
        CreateDiscountDatabase();
        if(CheckForDiscountCode(code))
        {
            var discountedprice = price * _discountDatabase[code];
            Console.WriteLine($"Discounted price for {price} with {code} is " + discountedprice);
        }

    }

    bool CheckForDiscountCode(String code)
    {
        if(_discountDatabase.ContainsKey(code))
        {
            return true;
        }
        else
        {
            //Discount code 'DIWALI' is not valid"
            Console.WriteLine("Discount code '" + code +  "' is not valid");
            return false;
        }
    }
}