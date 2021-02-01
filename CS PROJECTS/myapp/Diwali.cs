using System;
using System.Linq;
using System.Collections.Generic;

/*Check for different discount codes
DIWALI50 - give 50% discount
HOLI20 - give 20% discount
SUMMERSALE - give 10% discount

Write a function that takes parameters of product price and disocunt code. Return discounted price
*/

//

class DIWALI
{
public void DiscountCodeChecker(float price, string code)
{
    float discount = 1f;
    //Check for discount codes
    if(code == "DIWALI50")
    {
        Console.WriteLine("50% discount applied");
        //apply disount
        discount = 0.5f;
    }
    else if(code =="HOLI20")
    {
        Console.WriteLine("20% discount applied");
         //apply disount
        discount = 0.2f;
    }
    else if (code == "SUMMERSALE")
    {
        Console.WriteLine("10% discount applied");
         //apply disount
        discount = 0.1f;
    }
    else
    {
        //check for invalid code
        Console.WriteLine("Invalide code");
    }

    //if discount is appliedm than calculate price
    if(discount < 1)
    {
        Console.WriteLine("Your discounted price = " + (price * discount) + "₹");
    }
   
}

// DiscoutCodeChecker(7744, "DIWALI50");

}