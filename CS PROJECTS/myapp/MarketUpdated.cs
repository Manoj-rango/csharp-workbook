using System;
using System.Linq;
using System.Collections.Generic;

/* Market prices for rice
above 100kilos. 1kg price = 35.4₹
above 1000 kilos. 1kg price = 36.2₹
above 10000 kilos. 1 kg price = 36.5₹
below 100 kilos. 1kg price = 34₹

Market prices for chilli
above 100kilos. 1kg price = 89.4₹
above 1000 kilos. 1kg price = 92.2₹
above 10000 kilos. 1 kg price = 93.5₹
below 100 kilos. 1kg price = 72₹


Log price based on kilos provided by farmer. Use Minimum 2 functions

 */
class MarketPrice

{
    #region Class Variables

    private float _riceKilos;

    private float _chilliKilos;

    #region Properties

    public float RicePrice
    {
        get
        {
            float price = 0;
            if(_riceKilos < 100)
            {
                price = (_riceKilos * 34f);
            }
            else if (_riceKilos >= 100 && _riceKilos < 1000)
            {
                price = (_riceKilos * 35.4f);
            }
            else if (_riceKilos >= 1000 && _riceKilos < 10000)
            {
                price = (_riceKilos * 36.2f);
            }
            else if (_riceKilos >= 10000)
            {
                price = (_riceKilos * 36.5f);
            }

            return price;
        }

    }
    public float ChilliPrice
    {
        get
        {
            float price = 0;
            if(_chilliKilos < 100)
            {
                price = (_chilliKilos * 72);
            }
            else if (_chilliKilos >= 100 && _chilliKilos < 1000)
            {
                price = (_chilliKilos * 89.4f);
            }
            else if (_chilliKilos >= 1000 && _chilliKilos < 10000)
            {
                price = (_chilliKilos * 92.2f);
            }
            else if (ChilliPrice >= 10000)
            {
                price = (_chilliKilos * 93.5f);
            }

            return price;
        }

    }
    #endregion //ClassVariables
    #endregion //Properties


   public MarketPrice(float ricekilos,float chillikilos)
   {
       //get data from constructor
       _riceKilos = ricekilos;
       _chilliKilos = chillikilos;
   }

    // public MarketPrice()
    // {
    //     Console.WriteLine("Please enter RicePrice");
    //     RicePrice=float.Parse(Console.ReadLine());
    //     Console.Write("Please enter ChilliPrice");
    //     ChilliPrice=float.Parse(Console.ReadLine());
    // }
    
   public void MarketCalculator()
   {
       //print prices
       Console.WriteLine("\nRicePrice : " + RicePrice + "₹\nChilliPrice :" + ChilliPrice + "₹");
   }

}