using System;
using System.IO;

class SimpleFile
{
    public void Start()
    {
        //give path to save file. If you give only file name, it'll save in the same directory
        string path = "SimpleFile.txt";

        // NEW FILE CREATE: Create a file to write to.
        string createText = "Hello and Welcome" + Environment.NewLine;
        File.WriteAllText(path, createText);

        // EXISTING FILE/NEW FILE: Update text
        // This text is always added, making the file longer over time
        // if it is not deleted.        
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText);
        
        // EXISTING FILE ONLY: Read data
        // Open the file to read from.
        if(File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        else
        {
            Console.WriteLine("path is not available");
        }
    }
}