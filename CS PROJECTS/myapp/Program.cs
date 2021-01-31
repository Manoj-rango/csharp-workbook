using System;
using System.Linq;
using System.Collections.Generic;

namespace  myapp
{
    class Program
    {

        static void Main()
        {
            //   var BIll = new Billing();
            //   BIll.Start();

            //    var User1 = new Bank();
            //    Console.WriteLine("Account no(Encrypt): " + User1.Accountno);
            //    User1.PrintDetails();

            var student1 = new College();
           Console.WriteLine("students: " + student1.Students);
            Console.WriteLine("staffmembers: " + student1.staffmembers);
            student1.PublicSurvey();
        }

       
    }
}
