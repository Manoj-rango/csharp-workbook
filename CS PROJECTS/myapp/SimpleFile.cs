using System;
using System.IO;

// In simplefile concept we can use only strings
class SimpleFile
{
    public void Start()
    {
        string path = "SimpleFile.txt";

        //Creating a new file to write 
        string createText ="Want to be a program developer" + Environment.NewLine;
        File.WriteAllText(path,createText);

        //It opens the existing file 
        string appendText = "Forever and ever" + Environment.NewLine;
        File.AppendAllText(path,appendText);

        // It reads the file 
        if(File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        else
        {
            Console.Write("path is not available");     
        }

    }

}