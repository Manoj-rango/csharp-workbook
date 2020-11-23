using System;
using System.Linq;
using System.Collections.Generic;

class Accesbility
{

    int class_x = 15; //declared at class. Can be used throughout class

    public void Class_Funtion1()
    {
        int local_x = 10; //declared at this function and can be used only in this function
        Console.WriteLine(class_x);
    }

    void class_Function2()
    {
        class_x = 22;
        Console.WriteLine(class_x);
    }

}