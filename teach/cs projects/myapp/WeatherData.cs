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


}