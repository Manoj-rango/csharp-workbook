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

            var file1 = new SimpleFile();
            file1.Start();
        }
    }
}
