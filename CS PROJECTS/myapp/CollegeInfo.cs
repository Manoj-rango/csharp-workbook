using System;
using System.Linq;
using System.Collections.Generic;

class  College
{


    private int _students;


    public int Students
    {
        get
        {
            return _students;
        }

        set
        {
            if(value>10000)
            {
                Console.WriteLine("Can be considered as University");
            }
            _students=value;
        }
    }

    public int staffmembers
    {    
        get; set;
    }

    public int workers
    {
        get; set;
    }

    public void  PublicSurvey()
    {

        Console.WriteLine("Present no of students");
        staffmembers = int.Parse(Console.ReadLine());
        Console.WriteLine("Are you sure about that(Q/W)");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        //For further Conformation
        if(keyInfo.KeyChar == 'Q' || keyInfo.KeyChar == 'q')
        {
            Console.WriteLine("\n Details saved ");
            Console.WriteLine("\nstaffmembers :" +staffmembers);
        }
        else if(keyInfo.KeyChar == 'W' || keyInfo.KeyChar == 'w')
        {
            Console.WriteLine("\n Details not saved. Program quit. ");
        }
        else 
        {
            Console.WriteLine("\nwrong input.Program quit.");
        }



    }






}