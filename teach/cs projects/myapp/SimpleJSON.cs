using System;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

//make attributes to properties
public class PUBG_DATA
{
    public string Username {get; set;}
    public int Level {get; set;}
    public int Coins {get; set;}
}

//make attributes as fields
public class DataFields
{
    [JsonInclude] //Attribute Usage. Allows JsonSerializer to include fields
    public string Username;
    public int Level;
    public int Coins;
}

class SimpleJSON
{
    private PUBG_DATA _player = new PUBG_DATA();

    //data path
    private string path = "simple.json";
    
    public void WriteToJSON()
    {
        //fill data
        _player.Username = "TigerKill";
        _player.Level = 34;
        _player.Coins = 240;

        //options allow to make adjustments to organize data like indentation
        var options = new JsonSerializerOptions{WriteIndented = true};

        //convert our data to json using Json serialization
        //serialization = a process to convert attributes data into readeable/writable form
        //decoder is a reading process, writing is a encoding process
        var jsonstring = JsonSerializer.Serialize<PUBG_DATA>(_player, options);

        //write json string into a file
        File.WriteAllText(path, jsonstring);
    }

    public void ReadFromJSON()
    {
        var jsonString = File.ReadAllText(path);
        try
        {
            PUBG_DATA _data =  JsonSerializer.Deserialize<PUBG_DATA>(jsonString);

            Console.WriteLine(_data.Username + "-" + _data.Coins);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class SimpleJSON_Fields
{
    DataFields player = new DataFields();

    //data path
    string path = "simpleFields.json";
    
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
        var jsonstring = JsonSerializer.Serialize<DataFields>(player, options);

        //write json string into a file
        File.WriteAllText(path, jsonstring);
    }
}
