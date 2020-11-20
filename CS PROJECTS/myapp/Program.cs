using System;
using System.Linq;

namespace myapp
{
    class Practice
    {
        //practise entry point 
        public void Start()
        {
            logging("user0", "password0");
            GradeCalculator(765);
            MarketCalculator(2, 120);
        }
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
