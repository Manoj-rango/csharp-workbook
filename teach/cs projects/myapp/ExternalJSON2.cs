using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class WeatherForecastWithPOCOs2
{
    public DateTimeOffset Date;
    public int TemperatureCelsius;
    public string Summary;
    public string SummaryField;
    public IList<DateTimeOffset> DatesAvailable;
    public Dictionary<string, HighLowTemps2> TemperatureRanges;
    public string[] SummaryWords;
}

[Serializable]
public class HighLowTemps2
{
    public int High;
    public int Low;
}

class ExternalJSON2
{
    WeatherForecastWithPOCOs2 weatherForecast2 = new WeatherForecastWithPOCOs2();
    string fileName2 = "weather2.json";
    public void WriteToJSON2()
    {
        Console.WriteLine("WRITING2...");
        FillData2();
        var options2 = new JsonSerializerOptions
        {
            WriteIndented = true,
        };

        var jsonString2 = JsonSerializer.Serialize<WeatherForecastWithPOCOs2>(weatherForecast2,options2);

        File.WriteAllText(fileName2, jsonString2);
    }

    public void ReadFromJSON2()
    {
        Console.WriteLine("READING2.....");
        var jsonString2 = File.ReadAllText(fileName2);
        var forecastDE2 = JsonSerializer.Deserialize<WeatherForecastWithPOCOs2>(jsonString2);

        Console.WriteLine("TemperatureCelsius: "+ forecastDE2.TemperatureCelsius);
        Console.Write("Summary Words: ");
        var length2 = forecastDE2.SummaryWords.Length;
        for (int i =0;i<length2; i++)
        {
            if(i == length2-1)
            {
                Console.Write(forecastDE2.SummaryWords[i]);
            }
            else
            {
                Console.Write(forecastDE2.SummaryWords[i] + ", ");
            }
        }
    }

    void FillData2()
    {
        weatherForecast2.Date = DateTimeOffset.Now;
        weatherForecast2.TemperatureCelsius = 25;
        weatherForecast2.Summary = "Hot";
        weatherForecast2.DatesAvailable = new List<DateTimeOffset>();
        weatherForecast2.DatesAvailable.Add(DateTimeOffset.Now);
        weatherForecast2.DatesAvailable.Add(DateTimeOffset.Now);

        HighLowTemps2 hotTemps2 = new HighLowTemps2();
        hotTemps2.High = 60;
        hotTemps2.Low = 20;

        HighLowTemps2 coldTemps2 = new HighLowTemps2();
        coldTemps2.High = 20;
        coldTemps2.Low = -10;
        
        weatherForecast2.TemperatureRanges = new Dictionary<string, HighLowTemps2>();
        weatherForecast2.TemperatureRanges.Add("Hot", hotTemps2);
        weatherForecast2.TemperatureRanges.Add("Cold", coldTemps2);

        weatherForecast2.SummaryWords = new string[] {"Cool","Windy","Humid"};
    }
}