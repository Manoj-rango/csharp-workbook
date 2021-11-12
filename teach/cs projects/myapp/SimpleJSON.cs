using System;
using System.Text.Json;
using System.IO;

//make attributes to properties
public class PUBG_DATA
{
    public string Username {get; set;}
    public int Level {get; set;}
    public int Coins {get; set;}
}

class SimpleJSON
{
    PUBG_DATA player = new PUBG_DATA();

    //data path
    string path = "simple.json";
    
    public void WriteToJSON()
    {
        //fill data
        player.Username = "Navneeth";
        player.Level = 32;
        player.Coins = 2;

        //options allow to make adjustments to organize data like indentation
        var options = new JsonSerializerOptions{WriteIndented = true};

        //convert our data to json using Json serialization
        //serialization = a process to convert attributes data into readeable/writable form
        var jsonstring = JsonSerializer.Serialize<PUBG_DATA>(player, options);

        //write json string into a file
        File.WriteAllText(path, jsonstring);
    }
}