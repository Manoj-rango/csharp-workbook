using System;

class TestProperties
{
    //public field. Instances will have FULL access
    //fields can only be edited. No pre-processing can be done
    public int AccountIdEdit;
    //private field. Access is valid only within this class
    private int _account = 1246; 

    //read only. we can only receive value but can't set
    public int AccountId
    {
        get
        { 
            //you can use property as function
            Console.WriteLine("account no:" + _account + "\nFull account no:" + ShowFullAccountnumber(_account));
            return ShowFullAccountnumber(_account); 
        }
    }

    //property can be edited and received. They can be declared as fields
    public string Address
    {
        get;set;
    }

    void func1()
    {
        _account = 1245;
    }

    //functions let you pass parameters
    public int AccountIdFunc(bool isVIP)
    {
        return _account;
    }

    //access is limited to this class
    private int ShowFullAccountnumber(int id)
    {
        return id + 1015486;
    }

}

class TestProperties2
{
    //private field. Access is valid only within this class
    private int _account2; 
    void func1()
    {
        _account2 = 1231;
    }
}