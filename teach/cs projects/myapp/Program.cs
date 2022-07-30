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

            var test = new TestProperties();
            // //fields can be used left and right side
            // test.AccountIdEdit = 20;
            // var id = test.AccountIdEdit;
            
            //properties can be used left or right side based on access given
            var id2 = test.AccountId;
            // test.Address = "kmm";

            // var id3 = test.AccountIdFunc(false);
            
        }
    }
}
