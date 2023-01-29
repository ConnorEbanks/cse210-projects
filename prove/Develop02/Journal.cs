using System;
using System.Collections.Generic;
using System.IO;

class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    string file = "";
    public void Save(string file)
    {
        // save all entries out to the file
        

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{_entries}");
        }
        Console.WriteLine($"\nSaving entry to file {file} ");
    }

    public void Load(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }

        // load all entries from the file
        Console.WriteLine($"\nLoading from file {file} ");
    }
}