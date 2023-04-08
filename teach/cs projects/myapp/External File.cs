#if !NET7_0
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

[Serializable()]
public class SiteDetail
{
    public string Login;
    public string Password;
    public string Url;
}

public class ExternalFile
{
    string _filePath = "file.dat";
    List<SiteDetail> _siteList = new List<SiteDetail>();

    public void WriteDetails()
    {
        FillLogins();
        Console.WriteLine("WRITING...");
        Save(_filePath, _siteList);
    }

    public void LoadDetails()
    {
        Console.WriteLine("LOADING...");
        var loadedDetails = Read(_filePath);
        Console.WriteLine(loadedDetails.Count);
        foreach(var details in loadedDetails)
        {
            Console.WriteLine(details.Login);
        }
    }

    void FillLogins()
    {
        var details = new SiteDetail();
        details.Login = "user1";
        details.Password = "password1";
        details.Url = "sdf sdf";

        _siteList.Add(details);

        var details2 = new SiteDetail();
        details2.Login = "user2";
        details2.Password = "password2";
        details2.Url = "sdfaf /sdfsdfs";

        _siteList.Add(details2);

        foreach(var de in _siteList)
        {
            Console.WriteLine(de.Login);
        }
    }

    void Save(string filePath,List<SiteDetail> data)
    {
        Stream stream= File.Create(filePath);
        BinaryFormatter serializer = new BinaryFormatter();
        serializer.Serialize(stream, data);
        stream.Close();
    }

    List<SiteDetail> Read(string filePath)
    {
       if (File.Exists(filePath))
        {
            Stream stream= File.OpenRead(filePath);
            BinaryFormatter deserializer = new BinaryFormatter();
            var details= (List<SiteDetail>)deserializer.Deserialize(stream);
            stream.Close();
            return details;
        }
        return null; // file not exists
    }
}
#endif