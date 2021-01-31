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

            // var file1 = new SimpleFile();
            // file1.Start();           

            // var en1 = new MainClass();
            // en1.Start();

            var json1 = new ExternalJSON();
            json1.WriteToJSON();
            json1.ReadFromJSON();

        }
    }
}
