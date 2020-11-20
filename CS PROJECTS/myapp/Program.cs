using System;
using System.Linq;
using System.Collections.Generic;

namespace myapp
{
    class Practice
    {
        //practise entry point 
        public void Start()
        {
            // logging("user0", "password0");
            // GradeCalculator(765);
            // MarketCalculator(2, 120);
            Billing();
        }
#region Market
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

        float GetRicePrice(float kilos)
        {
            return 0;
        }

        float GetChilliPrice(float kilos)
        {
            return (kilos * 35.4f);
        }

        void MarketCalculator(float ChilliKilos, float RiceKilos)
        {
            Console.WriteLine( (GetRicePrice(RiceKilos) + GetChilliPrice(ChilliKilos)) + " Rupees");
        }

#endregion

#region GradeCalculator

        void GradeCalculator(int score)
        {
            float percent = (score/1000f) * 100;

            if(percent >= 90)
            {
                Console.WriteLine( "outstanding performance");
            }
            else if (percent >= 70 && percent < 90)
            {
                Console.WriteLine( " GOOD ");
            }
            else if(percent >= 60 && percent < 70)
            {
                Console.WriteLine( " AVERAGE ");
            }

        }
#endregion

#region Logging
    
        string [] userserver = new string[]{"user0", "user1", "user2"};
        string [] passwordserver = new string[] {"password0", "password1", "password2"};

        void logging ( string userid , string passwordid )
        {
            bool isuservalid =  userserver.Contains(userid);
            Console.WriteLine(isuservalid);
            if (    isuservalid )
            {
                Console.WriteLine(" user available ");
            }
            else
            {
                Console.WriteLine(" user unavailable ");
                return ;
            }

            int userindex = Array.IndexOf (userserver,userid);
            int passwordindex = Array.IndexOf(passwordserver,passwordid);

            if (userindex == passwordindex)
            {
                Console.WriteLine("login successsful ");
            }
            else 
            {
                Console.WriteLine(" login unsuccessful");
            }

        }

#endregion

#region BILLING
        // BILLING fruitsproduct 
        struct FruitStruct
        {
            public int ProductID;
            public string ProductName;
            public float  ProductPrice;
            public float DiscountPrice;
        }

        // Bill struct 
        struct BillStruct
        {
            // constructors
            public BillStruct(FruitStruct _fruit , int _quantity)
            {

                Fruit = _fruit;
                Quantity = _quantity;
            }
            public FruitStruct Fruit ;
            public int Quantity;

            public float GetBillprice()
            {
                return Fruit.ProductPrice * Quantity;
            }

            public float GetBillDiscountPrice()
            {
                return (Fruit.ProductPrice * Fruit.DiscountPrice) * Quantity;
            }
            
        }

        void Billing()
        {
            // creating fruits instances 
            FruitStruct Kiwi = new FruitStruct();
            Kiwi.ProductID = 192;
            Kiwi.ProductName = " Kiwi";
            Kiwi.ProductPrice = 50.2f;
            Kiwi.DiscountPrice = 1;

            
            FruitStruct Pineapple = new FruitStruct();
            Pineapple.ProductID = 297;
            Pineapple.ProductName = " Pineapple";
            Pineapple.ProductPrice = 90.23f;
            Pineapple.DiscountPrice = 0.9f;


            FruitStruct Avocado = new FruitStruct();
            Avocado.ProductID = 645;
            Avocado.ProductName = " Avocado";
            Avocado.ProductPrice = 80.3f;
            Avocado.DiscountPrice = 1;


            FruitStruct Pomegranate = new FruitStruct();
            Pomegranate.ProductID = 732;
            Pomegranate.ProductName = " Pomegranate";
            Pomegranate.ProductPrice = 40.3f;
            Pomegranate.DiscountPrice = 1;


            // Database of fruits 
            Dictionary<int,FruitStruct> FruitDatabase = new Dictionary<int,FruitStruct>();
            FruitDatabase.Add(Kiwi.ProductID, Kiwi);
            FruitDatabase.Add(Pineapple.ProductID , Pineapple);
            FruitDatabase.Add(Avocado.ProductID, Avocado);
            FruitDatabase.Add(Pomegranate.ProductID, Pomegranate);

            // BILL Database 
            List<BillStruct> BillList = new List<BillStruct>();
            // Scanning Products
            int scanneditem = 192;
            BillList.Add(new BillStruct (FruitDatabase[scanneditem],4));
            scanneditem = 297;
            BillList.Add(new BillStruct (FruitDatabase[scanneditem],2));
            scanneditem = 645;
            BillList.Add(new BillStruct (FruitDatabase[scanneditem],6));
            scanneditem = 732;
            BillList.Add(new BillStruct (FruitDatabase[scanneditem],8));

            // Print Bill
            Console.WriteLine("Item Purchased = "  + BillList.Count);
            int count = 0;
            foreach(var BillStruct in BillList )
            {
                count++;
                Console.WriteLine(count +" | "  + BillStruct.Fruit.ProductID + " | " + BillStruct.Fruit.ProductName + " | " + BillStruct.Quantity + " | " + BillStruct.Fruit.ProductPrice + "₹ | " + BillStruct.GetBillprice() + "₹ ");

            }

        }

#endregion
        
    }//end of practise

    class Program
    {
        // entry point 
        static void Main()
        {
            var practice = new Practice();
            practice.Start();
        }
    }
}
