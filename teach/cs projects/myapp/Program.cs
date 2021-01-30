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

            // var b1 = new Bank();
            // Console.WriteLine("Account no(Encrypt): " + b1.AccountNo);
            // b1.PrintDetails();

#region old_stuff
            // var json = new ExternalJSON();
            // json.WriteToJSON();
            // json.ReadFromJSON();
            
            var wea = new Weather();
            Console.WriteLine("Temperature: " + wea.Temperature);
            Console.WriteLine("WindSpeed: " + wea.WindSpeed);
            wea.TakeUserInput();
#endregion
        }
    }
}
