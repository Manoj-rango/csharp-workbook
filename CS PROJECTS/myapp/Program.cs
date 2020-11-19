using System;
using System.Linq;

namespace myapp
{
    class Program
    {
        
    static void GradeCalculator(int score)
    {
        float percent = (score/1000f) * 100;

        if(percent >= 90)
        {
            Console.WriteLine( "outstanding performance");
        }
        else if (percent >= 70 && percent < 90)
        {
            Console.WriteLine( " GOOD ");
        }
        else if(percent >= 60 && percent < 70)
        {
            Console.WriteLine( " AVERAGE ");
        }

    }   
    
    static string [] userserver = new string[]{"user0", "user1", "user2"};
    static string [] passwordserver = new string[] {"password0", "password1", "password2"};

    static void logging ( string userid , string passwordid )
    {
    bool isuservalid =  userserver.Contains(userid);
        Console.WriteLine(isuservalid);
        if (    isuservalid )
        {
            Console.WriteLine(" user available ");
        }
        else
        {
            Console.WriteLine(" user unavailable ");
            return ;
        }

        int userindex = Array.IndexOf (userserver,userid);
        int passwordindex = Array.IndexOf(passwordserver,passwordid);

        if (userindex == passwordindex)
        {
            Console.WriteLine("login successsful ");
        }
        else 
        {
            Console.WriteLine(" login unsuccessful");
        }

    }

    //logging("ncdjncjdnc","password1");   
        // entry point 
        static void Main()
        {
            GradeCalculator(678);
            logging("ncdjncjdnc","password1");   
        }
    }
}
