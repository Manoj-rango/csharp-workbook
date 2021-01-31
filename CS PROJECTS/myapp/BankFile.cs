using System;
using System.Linq;
using System.Collections.Generic;


class Bank
{
    #region class variables 
    private String _Name;

    private long _Mobileno;

    private long _Accountno;

    #region Properties
    public long Accountno
    {
        get
        {
            return Encrypt (_Accountno);
        }
    }
    public long Encrypt(long value)
    {
        return (value + 123);
    }
    public long Decrypt(long value)
    {
        return (value - 123);
    }

    public string Name
    {
        get
        {
            return(_Name);
        }

        //set(string value)
        // set
        // {
        //     if(value.Length >3)
        //     {
                
        //         _Name = value;
        //     }
        //     else
        //     {
        //         Console.WriteLine("name lenght should be more than 3 alphabets");
        //     }
        // }
    }

    // public long mobileno
    // {
    //     get
    //     {
    //         return _Mobileno;
    //     }
    // }
    #endregion //ClassVAriables
    #endregion //Properties

    public Bank(string name , long mobileno )
    {
        _Name =name;
        _Mobileno = mobileno;

        //generating random number
        _Accountno = 12387408853;

    }

    public Bank()
    {
        Console.WriteLine("please enter your name :");
        _Name=Console.ReadLine();
        Console.WriteLine("Please Enter your Mobile NO :");
        _Mobileno=long.Parse(Console.ReadLine());
          //generating random number
         _Accountno = 12387408853;

    }
    public void PrintDetails()
    {
        Console.WriteLine("Name : " + _Name + "\nMobileNo :" + _Mobileno + "\nAccountNo() :" + _Accountno);

    }

     public long GetAccountNo()
    {
        return _Accountno;
    }
    


}