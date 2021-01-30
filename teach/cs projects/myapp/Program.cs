using System;
using System.Linq;

namespace myapp
{
    class Practice
    {
        public void Start()
        {
            Function1();
        }

        void Function1()
        {
            Console.WriteLine(" boo yeah");
        }

    }

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Entry point");
            // var bill = new Billing2();
            // bill.GenereteBill();

            var b1 = new Bank("hades", 878454845);
            Console.WriteLine("Account no(Encrypt): " + b1.AccountNo);
            b1.PrintDetails();

#region old_stuff
            // var json = new ExternalJSON();
            // json.WriteToJSON();
            // json.ReadFromJSON();

            /*//user file
            var wea = new Weather();
            Console.WriteLine("Temperature: " + wea.Temperature);
            Console.WriteLine("WindSpeed: " + wea.WindSpeed);


            wea.WindSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("windspeed: " + wea.WindSpeed);
            // wea.WindForce = 343;*/
#endregion
        }
    }
}
