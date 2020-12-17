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

            // var json = new ExternalJSON();
            // json.WriteToJSON();
            // json.ReadFromJSON();

            //user file
            var account1 = new Bank("billy", 98745665656);
            // account1.PrintDetails();
            long x = account1.AccountNo;

            //account1.AccountNo = 23;
            Console.WriteLine("Name " + account1.Name);

            //account1.AccountNo = 2453;
            Console.WriteLine("2 changed no: " + account1.AccountNo);

        }
    }
}
