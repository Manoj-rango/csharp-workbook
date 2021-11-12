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

            var file1 = new SimpleJSON();
            file1.WriteToJSON();
 

            // string input = Console.ReadLine();
            // Console.WriteLine("I typed : " + input);
        }
    }
}
