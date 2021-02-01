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

    private float _GetRicePrice;

    private float _GetChilliPrice;

    #region Properties

    public float RiceKilos
    {
        get
        {
            return _GetRicePrice;
        }

        set
        {
                // _GetRicePrice=value;
                
                float price = 0;
            if(RiceKilos < 100)
            {
                price = (RiceKilos * 34f);
            }
            else if (RiceKilos >= 100 && RiceKilos < 1000)
            {
                price = (RiceKilos * 35.4f);
            }
            else if (RiceKilos >= 1000 && RiceKilos < 10000)
            {
                price = (RiceKilos * 36.2f);
            }
            else if (RiceKilos >= 10000)
            {
                price = (RiceKilos * 36.5f);
            }
        
        }
    }
    public float ChilliKilos
    {
        get
        {
            return _GetChilliPrice;
        }

        set
        {
            // _GetChilliPrice=value;

                float price = 0;
            if(ChilliKilos < 100)
            {
                price = (ChilliKilos * 72);
            }
            else if (ChilliKilos >= 100 && ChilliKilos < 1000)
            {
                price = (ChilliKilos * 89.4f);
            }
            else if (ChilliKilos >= 1000 && ChilliKilos < 10000)
            {
                price = (ChilliKilos * 92.2f);
            }
            else if (ChilliKilos >= 10000)
            {
                price = (ChilliKilos * 93.5f);
            }
            
        
        }
    }
    #endregion //ClassVariables
    #endregion //Properties


   public MarketPrice(float ricekilos,float chillikilos)
   {
       _GetRicePrice=ricekilos;
       _GetChilliPrice=chillikilos;
   }

    // public MarketPrice()
    // {
    //     Console.WriteLine("Please enter RiceKilos");
    //     RiceKilos=float.Parse(Console.ReadLine());
    //     Console.Write("Please enter ChilliKilos");
    //     ChilliKilos=float.Parse(Console.ReadLine());
    // }
    
   public void MarketCalculator()
   {
       Console.WriteLine("\nRicePrice : " + _GetRicePrice + "\nChilliPrice :" + _GetChilliPrice + "₹");
   }

}