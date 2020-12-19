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
            var wea = new Weather();
            Console.WriteLine("Temperature: " + wea.Temperature);
            Console.WriteLine("WindSpeed: " + wea.WindSpeed);


            wea.WindSpeed = 23;
            wea.WindForce = 343;
        }
    }
}
