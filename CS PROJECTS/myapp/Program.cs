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

               var User1 = new Bank();
               Console.WriteLine("Account no(Encrypt): " + User1.Accountno);
               User1.PrintDetails();

//             var public = new College();
// `           Console.WriteLine("students: " + public.students);
//             Console.WriteLine("staffmembers: " + public.staffmembers);
//             public.PublicSurvey();
        }

       
    }
}
