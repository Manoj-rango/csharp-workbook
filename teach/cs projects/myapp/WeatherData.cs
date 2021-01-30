using System;
using System.Collections.Generic;
class Weather
{
    private float _temperature;
    
    //DATA is saved in an external variable _temperature
    public float Temperature
    {
        //gets value
        get
        {
            return _temperature;
        }

        //sets value
        set
        {
            if(value < 0)
            {
                Console.WriteLine("IT MIGHT SNOW!!!");
            }
            _temperature = value;
        }
    }

    //DATA is saved within property
    public float WindSpeed
    {
        get; set;
    }

    //DATA is saved within property
    public float RainFallCM
    {
        get; set;
    }

    public void TakeUserInput()
    {
        // wea.WindForce = 343;
        Console.WriteLine("Type current windspeed:");
        //get input from user
        WindSpeed = float.Parse(Console.ReadLine());
        Console.WriteLine("Arew you sure(Y/N):");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        //Ask for confirmation?
        if(keyInfo.KeyChar == 'Y' || keyInfo.KeyChar == 'y')
        {
            Console.WriteLine("\nDetails saved.");
            Console.WriteLine("windspeed: " + WindSpeed);
        }
        else if(keyInfo.KeyChar == 'N' || keyInfo.KeyChar == 'n')
        {
            Console.WriteLine("\nDetails not saved. Program quit.");
        }
        else
        {
            Console.WriteLine("\nwrong input.Program quit.");
        }
    }


}