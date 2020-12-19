using System;
using System.Linq;
using System.Collections.Generic;

class Bank
{
    #region class variables 
    private String _Name;

    private long _Mobileno;

    public long _Accountno;

    #region Properties
    public long Accountno
    {
        get{
            return(_Accountno);
        }
    }

    public string Name
    {
        get{
            return(_Name);
        }
    }

    public int BranchCode
    {
        get{
            return(6731);
        }
    }

    #endregion //ClassVAriables
    #endregion //Properties

    public Bank(string name , long mobileno )
    {
        _Name =name;
        _Mobileno = mobileno;

        //generating random number
        _Accountno = 12387408853;

    }

    public void PrintDetails()
    {
        Console.WriteLine("Name : " + _Name + "\nMobileNo :" + _Mobileno);

    }




}