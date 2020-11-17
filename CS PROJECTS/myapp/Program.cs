using System;

namespace myapp
{
    class Program
    {
        static void manoh()
        {
            Console.WriteLine("kumar");
        }
        static void gradecalculator(int score)
        {
            Console.WriteLine(score);
            manoh();
        }
        // entry point 
        static void Main()
        {
            Console.WriteLine("Hello World!");
            gradecalculator(12);
           // manoh();
        }
    }
}
